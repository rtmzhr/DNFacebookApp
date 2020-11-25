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
        private bool m_IsFetchedFriends = false;
        private List<User> m_FriendsDesplayedInListBox = new List<User>();
        public FriendsForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            m_LoggedInProfilePictureBox.Load(m_LoggedInUser.PictureLargeURL);
            this.m_FriendNameTextBox.TextChanged += updateFriendsListBox;
        }

        private void updateFriendsListBox(object sender, EventArgs e)
        {
            string textBoxResult = m_FriendNameTextBox.Text;
            m_FriendsListBox.Items.Clear();
            m_FriendsDesplayedInListBox.Clear();
            comapreStringsAndAddToListBox(textBoxResult, m_LoggedInUser);

            foreach (User friend in m_LoggedInUser.Friends)
            {
                comapreStringsAndAddToListBox(textBoxResult, friend);
            }

            if (m_FriendsListBox.Items.Count > 0)
            {
                m_FriendsListBox.SelectedIndex = 0;
            }

        }

        private void comapreStringsAndAddToListBox(string i_textBoxResult, User i_FriendToCompare)
        {
            if (i_FriendToCompare.Name.ToLower().Contains(i_textBoxResult.ToLower()))
            {
                m_FriendsDesplayedInListBox.Add(i_FriendToCompare);
                m_FriendsListBox.Items.Add(i_FriendToCompare.Name);
            }
        }

        private void fetchFriendsList()
        {
            if (!m_IsFetchedFriends)
            {
                m_IsFetchedFriends = true;
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    m_FriendsDesplayedInListBox.Add(friend);
                    m_FriendsListBox.Items.Add(friend.Name);
                }

                m_FriendsListBox.SelectedIndex = 0;
            }
        }

        private void ShowFriendInfo_Click(object sender, EventArgs e)
        {

            m_UserInfoForm = new UserInfoForm(m_FriendsDesplayedInListBox[m_FriendsListBox.SelectedIndex]);
            m_UserInfoForm.Show();

        }

        private void m_FriendsButton_Click(object sender, EventArgs e)
        {
            fetchFriendsList();
        }


    }
}
