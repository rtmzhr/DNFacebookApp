using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DN_EX1.InfoForms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DN_EX1
{
    public partial class MainForm : Form
    {
        private User m_LoggedInUser;

        private LoginForm m_LoginForm;
        private EventsForm m_EventsForm;
        private UserInfoForm m_UserInfoForm;
        private PostInfoForm m_PostInfoForm;
        private FriendsForm m_FriendsForm;
        private AlbumsForm m_AlbumsForm;
        private GroupsForm m_GroupsForm;
        private MemoriesForm m_MemoriesForm;
        

        public MainForm(LoginForm i_LoginForm, User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_LoginForm = i_LoginForm;
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            fetchInfo();
        }

        private void fetchInfo()
        {
            this.m_ProfilePictureBox.Load(m_LoggedInUser.PictureLargeURL);
            this.m_WelcomeLabel.Text = "Welcome " + m_LoggedInUser.FirstName
                + " " + m_LoggedInUser.LastName + "!";

            bool hasCoverPhoto = false;
            Album coverPhotosAlbum = null;
            foreach(Album album in m_LoggedInUser.Albums)
            {
                if (album.Name == "Cover Photos")
                {
                    if(album.Count > 0)
                    {
                        hasCoverPhoto = true;
                        coverPhotosAlbum = album;                        
                    }

                    break;
                }
            }

            if(hasCoverPhoto)
            {
                m_CoverPhotoPictureBox.Load(coverPhotosAlbum.Photos[0].PictureNormalURL);
            }
 
        }

              

        private void postButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.m_NewPostTextBox.Text))
                {
                    m_LoggedInUser.PostStatus(this.m_NewPostTextBox.Text);
                    fetchPosts();
                }
                else
                {
                    MessageBox.Show("Please Write Something ;)");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Couldn't Post");
            }
            
        }

        private void fetchPosts()
        {
            if (m_LoggedInUser.Posts.Count > 0)
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (!string.IsNullOrEmpty(post.Description))
                    {
                        this.m_PostsListBox.Items.Add(post.Description);
                    }
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser != null)
            {
                FacebookService.Logout();
                m_LoginForm.AppSettings.RememberMe = false;
                m_LoginForm.AppSettings.SaveToFile();
                m_LoginForm.Show();
                this.Dispose();
            }
        }

        private void findEventButton_Click(object sender, EventArgs e)
        {
            m_EventsForm = new EventsForm(m_LoggedInUser, this);
            m_EventsForm.Show();
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
           
            m_UserInfoForm = new UserInfoForm(m_LoggedInUser);
            m_UserInfoForm.Show();
        }

        private void userInfoButton_Click(object sender, EventArgs e)
        {
             profilePictureBox_Click(sender, e);
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            m_FriendsForm = new FriendsForm(m_LoggedInUser);
            m_FriendsForm.Show();
        }

        private void albumsButton_Click(object sender, EventArgs e)
        {
            m_AlbumsForm = new AlbumsForm(m_LoggedInUser);
            m_AlbumsForm.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Environment.Exit(0);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_LoginForm.AppSettings.SaveToFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_LoginForm.Hide();
            m_LoginForm.LoadingForm.Hide();
        }

        private void memoryButton_Click(object sender, EventArgs e)
        {
            m_MemoriesForm = new MemoriesForm(m_LoggedInUser);
            m_MemoriesForm.Show();

        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            m_GroupsForm = new GroupsForm(m_LoggedInUser);
            m_GroupsForm.Show();
        }

        private void fetchPostsButton_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void showPostButton_Click(object sender, EventArgs e)
        {
            m_PostInfoForm = new PostInfoForm(getPost(m_LoggedInUser.Posts, (string)m_PostsListBox.SelectedItem));
            m_PostInfoForm.Show();
        }

        private Post getPost(FacebookObjectCollection<Post> posts, string i_PostDescription)
        {
            Post targetPost = null;
            foreach(Post post in m_LoggedInUser.Posts)
            {
                if(post.Description == i_PostDescription)
                {
                    targetPost = post;
                    break;
                }
            }

            return targetPost;
        }
    }
}
