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
        AppSettings m_AppSettings;
        private LoadingForm m_LoadingForm;
        private const string k_AppID = "673993633490839";
        public LoginForm()
        {
            InitializeComponent();
            m_LoadingForm = new LoadingForm();
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            m_AppSettings = AppSettings.loadFromFile();
            connectByRememberMe();
        }

        private void connectByRememberMe()
        {
            LoginResult res;

            if (m_AppSettings.RememberMe && !string.IsNullOrEmpty(m_AppSettings.LastAccsessToken))
            {
                res = FacebookService.Connect(m_AppSettings.LastAccsessToken);
                tryToConnect(res);
            }            
        }

        private void tryToConnect(LoginResult i_Res)
        {
            if (!string.IsNullOrEmpty(i_Res.AccessToken))
            {
                this.Hide();
                m_LoadingForm.Show();
                MainForm f = new MainForm(this, i_Res.LoggedInUser);
                updateAppSettings(i_Res);                
                f.Show();
                
            }
            else
            {
                MessageBox.Show("Cannot Login");
            }
        }

        private void updateAppSettings(LoginResult i_Res)
        {
            m_AppSettings.RememberMe = rememberMeCheckBox.Checked;
            m_AppSettings.LastAccsessToken = i_Res.AccessToken;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginResult res;

            res = FacebookService.Login(k_AppID,
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
                    "user_hometown",
                    "groups_access_member_info");
            tryToConnect(res);

        }

     
        public AppSettings AppSettings
        {
            get { return m_AppSettings; }
        }

        public LoadingForm LoadingForm
        {
            get { return m_LoadingForm; }
        }
    }
}
