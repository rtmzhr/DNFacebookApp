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
        private User m_LoggedInUSer;
        private Form m_LoginForm;

        public MainForm(Form i_LoginForm, User i_LoggedInUser)
        {
            m_LoggedInUSer = i_LoggedInUser;
            m_LoginForm = i_LoginForm;
            InitializeComponent();
            fetchInfo();
        }

        private void fetchInfo()
        {
            fetchBasicInfo();
            this.profilePictureBox.Load(m_LoggedInUSer.PictureLargeURL);
            this.welcomeLabel.Text = "Welcome " + m_LoggedInUSer.FirstName
                + " " + m_LoggedInUSer.LastName + "!";

            fetchFriendsList();
            fetchPosts();


            // CHECK
            fetchAlbums();

        }

        private void fetchBasicInfo()
        {
            this.aboutListBox.Items.Add("Email : " + m_LoggedInUSer.Email);
            this.aboutListBox.Items.Add("Gender : " + m_LoggedInUSer.Gender);
            this.aboutListBox.Items.Add("Birthday : " + m_LoggedInUSer.Birthday);
            this.aboutListBox.Items.Add("HomeTown : " + m_LoggedInUSer.Hometown);
            this.aboutListBox.Items.Add("Location : " + m_LoggedInUSer.Location);
            this.aboutListBox.Items.Add("Religion : " + m_LoggedInUSer.Religion);
            this.aboutListBox.Items.Add("Relationship Status : " + m_LoggedInUSer.RelationshipStatus);
        }

        // CHECK
        private void fetchAlbums()
        {
            int count = 0;
            foreach (Album album in m_LoggedInUSer.Albums)
            {
                if (count > 8)
                {
                    break;
                }
                //this.m_Collage.Add(album.Pictures.);
            }
        }

        private void fetchFriendsList()
        {
            foreach (User friend in m_LoggedInUSer.Friends)
            {
                this.friendsListBox.Items.Add(friend.Name);
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.newPostTextBox.Text))
            {
                m_LoggedInUSer.PostStatus(this.newPostTextBox.Text);
                fetchPosts();
            }
            else
            {
                MessageBox.Show("Please Write Something ;)");
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in m_LoggedInUSer.Posts)
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
            if(m_LoggedInUSer != null)
            {
                FacebookService.Logout();
                m_LoginForm.Show();
                this.Dispose();
            }
        }
    }
}
