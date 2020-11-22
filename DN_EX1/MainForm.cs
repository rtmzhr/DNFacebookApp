using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DN_EX1
{
    public partial class MainForm : Form
    {
        private User m_LoggedInUser;
        private LoginForm m_LoginForm;
        private FindEventsForm m_EventsForm;
        private UserInfoForm m_UserInfoForm;
        private FriendsForm m_FriendsForm;
        private AlbumsForm m_AlbumsForm;

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
            this.profilePictureBox.Load(m_LoggedInUser.PictureLargeURL);
            this.welcomeLabel.Text = "Welcome " + m_LoggedInUser.FirstName
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
            
            // fetchFriendsList();
            // fetchPosts();
            // // CHECK
            // fetchAlbums();

        }

        

        // CHECK
        private void fetchAlbums()
        {
            int count = 0;
            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (count > 8)
                {
                    break;
                }
                //this.m_Collage.Add(album.Pictures.);
            }
        }

        

        private void postButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.newPostTextBox.Text))
            {
                m_LoggedInUser.PostStatus(this.newPostTextBox.Text);
                fetchPosts();
            }
            else
            {
                MessageBox.Show("Please Write Something ;)");
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if(!string.IsNullOrEmpty(post.Caption) || !string.IsNullOrEmpty(post.Description) ||
                    !string.IsNullOrEmpty(post.Message))
                {
                    if (!string.IsNullOrEmpty(post.Caption))
                    {
                        this.postsListBox.Items.Add(post.Caption);
                    }
                    if (!string.IsNullOrEmpty(post.Description))
                    {
                        this.postsListBox.Items.Add(post.Description);
                    }
                    if(!string.IsNullOrEmpty(post.Message))
                    {
                        this.postsListBox.Items.Add( post.Message);
                    }

                    this.postsListBox.Items.Add("");
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser != null)
            {
                FacebookService.Logout();
                m_LoginForm.Show();
                this.Dispose();
            }
        }

        private void findEventButton_Click(object sender, EventArgs e)
        {
            m_EventsForm = new FindEventsForm(m_LoggedInUser, this);
            m_EventsForm.Show();
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
           
            m_UserInfoForm = new UserInfoForm(m_LoggedInUser);
            m_UserInfoForm.Show();
        }

        private void m_UserInfoButton_Click(object sender, EventArgs e)
        {
             profilePictureBox_Click(sender, e);
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            m_FriendsForm = new FriendsForm(m_LoggedInUser);
            m_FriendsForm.Show();
        }

        private void m_AlbumsButton_Click(object sender, EventArgs e)
        {
            m_AlbumsForm = new AlbumsForm(m_LoggedInUser);
            m_AlbumsForm.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Environment.Exit(0);
        }

    }
}
