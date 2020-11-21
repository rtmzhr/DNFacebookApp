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
    public partial class FindEventsForm : Form
    {

        private User m_LoggedInUser;
        private MainForm m_MainForm;

        public FindEventsForm(User i_LoggedInUSer, MainForm i_MainForm)
        {
            m_LoggedInUser = i_LoggedInUSer;
            m_MainForm = i_MainForm;
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            foreach ( User friend in m_LoggedInUser.Friends)
            {
                foreach( Event friendEvent in friend.EventsCreated)
                {
                    if (DateTime.Compare(m_FromDateTime.Value, DateTime.Now) != 0 ||
                        DateTime.Compare(m_UntilDateTime.Value, DateTime.Now) != 0)
                    {
                        if (DateTime.Compare(m_FromDateTime.Value, (DateTime)friendEvent.StartTime) > 0 ||
                            DateTime.Compare(m_UntilDateTime.Value, (DateTime)friendEvent.EndTime) > 0)
                        {
                            break;
                        }
                    }
                    int limit;
                    if( Int32.TryParse(m_PeopleLimitTextBox.Text, out limit))
                    {
                        if (friendEvent.AttendingCount > limit)
                        {
                            break;
                        }
                    }
                    eventsListBox.Items.Add(friendEvent);
                    
                }
            }
        }
        }
    }

