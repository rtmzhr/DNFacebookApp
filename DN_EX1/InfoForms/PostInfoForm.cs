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

namespace DN_EX1.InfoForms
{
    public partial class PostInfoForm : Form
    {
        public PostInfoForm(Post i_Post)
        {
            InitializeComponent();
            m_DateValueLabel.Text = i_Post.CreatedTime.ToString();
            m_CaptionTextBox.Text = i_Post.Caption;
            m_DescriptionTextBox.Text = i_Post.Description;
            m_MessageTextBox.Text = i_Post.Message;
        }
    }
}
