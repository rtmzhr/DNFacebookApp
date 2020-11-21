using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DN_EX1
{
    public partial class FriendsForm : Form
    {
        private User m_LoggedInUser;
        private UserInfoForm m_UserInfoForm;
        public FriendsForm(User i_LoggedInUser)
        {
            m_UserInfoForm = new UserInfoForm();
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            m_LoggedInProfilePictureBox.Load(m_LoggedInUser.PictureLargeURL);
        }
        private void fetchFriendsList()
        {
            this.m_FriendsListBox.Items.Add(m_LoggedInUser.Name);
            foreach (User friend in m_LoggedInUser.Friends)
            {
                this.m_FriendsListBox.Items.Add(friend.Name);
            }
        }

        private void ShowFriendInfo_Click(object sender, EventArgs e)
        {
            
            //m_UserInfoForm.Init(getFriend((string)m_FriendsListBox.SelectedItem));
            m_UserInfoForm.Init(m_LoggedInUser);
            m_UserInfoForm.Show();
        }

        private User getFriend(string i_FriendName)
        {
            User targetFriend = null;
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if( friend.Name == i_FriendName)
                {
                    targetFriend = friend;
                    break;
                }
            }

            return targetFriend;
        }

        private void m_FriendsButton_Click(object sender, EventArgs e)
        {
            fetchFriendsList();
        }

        private void m_SearchFriendButton_Click(object sender, EventArgs e)
        {
            if(getFriend(m_FriendNameTextBox.Text) != null)
            {
                m_FriendsListBox.SelectedItem = m_FriendNameTextBox.Text;
                ShowFriendInfo_Click(null, EventArgs.Empty);
            }
        }
    }
}
