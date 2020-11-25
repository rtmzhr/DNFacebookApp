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
            init(i_LoggedUser);
        }

        private void init(User i_User)
        {
            this.Text = i_User.Name;
            this.m_ProfilePictureBox.LoadAsync(i_User.PictureNormalURL);
            this.m_UserNameLabel.Text = i_User.Name;
            this.m_EmailValueLabel.Text = i_User.Email;
            this.m_HometownValueLabel.Text = i_User.Hometown != null ?
                i_User.Hometown.Name : string.Empty;
            this.m_BirthdayValueLabel.Text = i_User.Birthday;
            this.m_SexValueLabel.Text = i_User.Gender.Value.ToString();
            this.m_ReligionValueLabel.Text = i_User.Religion;

            if (i_User.RelationshipStatus.HasValue)
            {
                User.eRelationshipStatus RelationshipStatus = i_User.RelationshipStatus.Value;
                this.m_RelationshipValueLabel.Text = RelationshipStatus.ToString();
            }

        }

    }
}
