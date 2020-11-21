using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Facebook;

namespace DN_EX1
{
    /// <summary>
    /// Facebook user info form
    /// </summary>
    public partial class UserInfoForm : Form
    {
        private User m_LoggedUser;

        public UserInfoForm(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            Init(i_LoggedUser);
        }
        public UserInfoForm()
        {
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }

        public void Init(User i_User)
        {
            this.Text = i_User.Name;
            this.picture_UserPicture.LoadAsync(i_User.PictureNormalURL);
            this.labelUserName.Text = i_User.Name;
            this.labelBirthdayResult.Text = i_User.Birthday;
            this.labelHometownResult.Text = i_User.Hometown != null ?
                i_User.Hometown.Name : string.Empty;
            this.labelEmailResult.Text = i_User.Email;
            this.labelSexResult.Text = i_User.Gender.Value.ToString();
            this.labelReligionResult.Text = i_User.Religion;

            if (i_User.RelationshipStatus.HasValue)
            {
                User.eRelationshipStatus RelationshipStatus = i_User.RelationshipStatus.Value;
                this.labelRelationshipResult.Text = RelationshipStatus.ToString();
            }

        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStatus.Text))
            {
                MessageBox.Show("Status is empty");
            }
            else
            {
                if (PostStatus(textBoxStatus.Text, m_LoggedUser))
                {
                    textBoxStatus.Clear();
                }
            }
        }

        public bool PostStatus(string i_StatusToPost, User i_UserToPostIn)
        {
            bool valueToReturn = true;
            try
            {
                i_UserToPostIn.PostStatus(i_StatusToPost);
            }
            catch (FacebookOAuthException OAuthException)
            {
                MessageBox.Show(OAuthException.Source + ": " + OAuthException.Message);
                valueToReturn = false;
            }

            return valueToReturn;
        }
    }
}
