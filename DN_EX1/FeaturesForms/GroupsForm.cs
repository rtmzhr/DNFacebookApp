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
    public partial class GroupsForm : Form
    {
        private User m_LoggedInUser;
        private List<string> m_LoggedInUserGroups = new List<string>();

        public GroupsForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            m_LoggedInProfilePictureBox.Load(m_LoggedInUser.PictureLargeURL);
            m_GroupNameTextBox.TextChanged += onGroupNameTextBoxChanged;
        }

        private void showGroupInfo_Click(object sender, EventArgs e)
        {
            foreach (Group group in m_LoggedInUser.Groups)
            {
                this.m_GroupsListBox.Items.Add(group.Name);
            }
        }

        private void onGroupNameTextBoxChanged(object sender, EventArgs e)
        {
            List<string> groupsToRemove = new List<string>();
            List<string> groupsToAdd = new List<string>();
            foreach (string groupName in m_LoggedInUserGroups)
            {
                if (!groupName.ToLower().Contains(m_GroupNameTextBox.Text))
                {
                    groupsToRemove.Add(groupName);
                }
                else if (!m_GroupsListBox.Items.Contains(groupName))
                {
                    groupsToAdd.Add(groupName);
                }
            }

            foreach (string groupName in groupsToRemove)
            {
                m_GroupsListBox.Items.Remove(groupName);
            }
            foreach (string groupName in groupsToAdd)
            {
                m_GroupsListBox.Items.Add(groupName);
            }
        }

        private Group getGroup(string i_GroupName)
        {
            Group targetGroup = null;
            foreach (Group group in m_LoggedInUser.Groups)
            {
                if (group.Name == i_GroupName)
                {
                    targetGroup = group;
                    break;
                }
            }

            return targetGroup;
        }

        private void fetchGroupsButton_Click(object sender, EventArgs e)
        {
            foreach (Group group in m_LoggedInUser.Groups)
            {
                m_GroupsListBox.Items.Add(group.Name);
                m_LoggedInUserGroups.Add(group.Name);
            }
        }
    }
}
