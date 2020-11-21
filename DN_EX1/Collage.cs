using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DN_EX1
{
    public class Collage : Control
    {
        private List<PictureBox> m_Items = new List<PictureBox>();
        private Size m_ImageSize;

        
        public void Add(string i_ImageURL)
        {
            PictureBox current = new PictureBox();
            current.Load(i_ImageURL);
            int imageIndex = m_Items.Count;
            current.Location = new Point(this.Location.X + m_ImageSize.Width * imageIndex % 3,
                this.Location.Y + m_ImageSize.Height * imageIndex / 3);
            m_Items.Add(current);
        }

        public void Add(Image i_Image)
        {
            PictureBox current = new PictureBox();
            current.Image = i_Image;
            int imageIndex = m_Items.Count;
            current.Location = new Point(this.Location.X + m_ImageSize.Width * imageIndex % 3,
                this.Location.Y + m_ImageSize.Height * imageIndex / 3);
            m_Items.Add(current);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            m_ImageSize = new Size(Size.Width / 9, Size.Height / 9);
            foreach (PictureBox pic in m_Items)
            {
                pic.Size = m_ImageSize;
            }
        }
        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            int imageIndex = 0;
            foreach (PictureBox pic in m_Items)
            {
                pic.Location = new Point(this.Location.X + m_ImageSize.Width * imageIndex % 3,
                this.Location.Y + m_ImageSize.Height * imageIndex++ / 3);
            }
        }
    }

}
