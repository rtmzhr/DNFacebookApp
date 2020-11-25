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
using static FacebookWrapper.ObjectModel.Event;

namespace DN_EX1
{
    public partial class EventsForm : Form
    {

        private User m_LoggedInUser;
        private MainForm m_MainForm;

        public EventsForm(User i_LoggedInUSer, MainForm i_MainForm)
        {
            m_LoggedInUser = i_LoggedInUSer;
            m_MainForm = i_MainForm;
            Application.EnableVisualStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
        }

        private void searchEventButton_Click(object sender, EventArgs e)
        {
           
            List<string> eventsToRemove = new List<string>();
            int limit = int.MaxValue;
            Int32.TryParse(m_PeopleLimitTextBox.Text, out limit);

            foreach (string eventName in eventsListBox.Items)
            {
                Event curEvent = getEvent(m_LoggedInUser.Events, eventName);
                if (DateTime.Compare(m_FromDateTime.Value, DateTime.Now) != 0 ||
                        DateTime.Compare(m_UntilDateTime.Value, DateTime.Now) != 0)
                {
                    if (DateTime.Compare(m_FromDateTime.Value, (DateTime)curEvent.StartTime) > 0 )
                    {
                        eventsToRemove.Add(eventName);
                        break;
                    }
                }
                if (curEvent.AttendingCount > limit)
                {
                    eventsToRemove.Add(eventName);
                    break;
                }
                
                if (!checkPrivacy(curEvent))
                {
                    eventsToRemove.Add(eventName);
                    break;
                }
            }

            foreach(string eventName in eventsToRemove)
            {
                eventsListBox.Items.Remove(eventName);
            }
        }

        private bool checkPrivacy(Event curEvent)
        {
            bool toKeep = false;

            if (m_OpenCheckBox.Checked && curEvent.Privacy == ePrivacy.Open)
            {
                toKeep = true;
            }
            if (m_CloseCheckBox.Checked && curEvent.Privacy == ePrivacy.Closed)
            {
                toKeep = true;
            }
            if (m_SecretCheckBox.Checked && curEvent.Privacy == ePrivacy.Secret)
            {
                toKeep = true;
            }

            return toKeep;
        }

        private Event getEvent(FacebookObjectCollection<Event> events, string eventName)
        {
            Event targetEvent = null;
            foreach (Event e in events)
            {
                if(e.Name == eventName)
                {
                    targetEvent = e;
                    break;
                }
            }

            return targetEvent;
        }

        private void fetchMyEvents_Click(object sender, EventArgs e)
        {
            foreach( Event ev in m_LoggedInUser.Events)
            {
                eventsListBox.Items.Add(ev.Name);
            }
        }

        private void showFrienInfo_Click(object sender, EventArgs e)
        {
            EventInfoForm info = new EventInfoForm(getEvent(m_LoggedInUser.Events, (string)eventsListBox.SelectedItem));
            info.Show();
        }

        private void fetchFriendsEvents_Click(object sender, EventArgs e)
        {
            foreach(User friend in m_LoggedInUser.Friends)
            {
                foreach (Event ev in friend.Events)
                {
                    eventsListBox.Items.Add(ev.Name);
                }
            }
        }
    }
    }

