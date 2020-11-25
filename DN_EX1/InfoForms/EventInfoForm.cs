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
    public partial class EventInfoForm : Form
    {
        public EventInfoForm(Event i_Event)
        {
            InitializeComponent();
            m_EventPictureBox.LoadAsync(i_Event.PictureLargeURL);
            m_NameLabel.Text = i_Event.Name;
            m_StartTimeValueLabel.Text = i_Event.StartTime.ToString();
            m_InterestedCountLabel.Text = i_Event.InterestedCount.ToString();
            m_AttendingCountLabel.Text = i_Event.AttendingCount.ToString();
            m_MaybeCountLabel.Text = i_Event.MaybeCount.ToString();
            m_NoReplyCountLabel.Text = i_Event.NoReplyCount.ToString();
            m_PrivacyValueLabel.Text = i_Event.Privacy.ToString();
            m_DescriptionTextBox.Text = i_Event.Description;
            
        }

      
    }
}
