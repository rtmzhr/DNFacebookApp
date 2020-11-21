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
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DN_EX1
{
    public partial class LoginForm : Form
    {
        private const string k_AppID = "673993633490839";
        public LoginForm()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginResult res = FacebookService.Login(k_AppID,
                    "public_profile",
                    "email",
                    "publish_to_groups",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_tagged_places",
                    "user_videos",
                    "publish_to_groups",
                    "groups_access_member_info",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown");
            if(!string.IsNullOrEmpty(res.AccessToken))
            {
                MainForm f = new MainForm(this, res.LoggedInUser);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cannot Login");
            }
        }
    }
}
