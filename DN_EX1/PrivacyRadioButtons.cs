using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DN_EX1
{
    public partial class PrivacyRadioButtons : Control
    {
        private Form m_Form;
        public PrivacyRadioButtons(Form i_Form)
        {
            m_Form = i_Form;
            InitializeComponent();
        }
    }
}
