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
    public partial class AlbumsForm : Form
    {

        private User m_LoggedInUser;
        private List<string> m_CurrentAlbumUrlPhotos;
        private int m_CurrentPhotoIndex = 0;
        public AlbumsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_AlbumsNamesListBox.SelectedIndexChanged += onChangeSelectedAlbum;
            m_CurrentAlbumUrlPhotos = new List<string>();

            fetchAlbumsNames();
            m_AlbumsNamesListBox.SelectedIndex = 0;
            getCurrentAlbumPhotosURL();
            displayPhoto();
        }

        private void displayPhoto()
        {
            if (m_CurrentAlbumUrlPhotos.Count > 0)
            {
                m_CurrentPhotoPictureBox.Load(m_CurrentAlbumUrlPhotos[0]);
            }
        }

        private void getCurrentAlbumPhotosURL()
        {
            int selectedAlbumIndex = m_AlbumsNamesListBox.SelectedIndex;
            if (selectedAlbumIndex == m_LoggedInUser.Albums.Count)
            {
                foreach (Photo photo in m_LoggedInUser.PhotosTaggedIn)
                {
                    m_CurrentAlbumUrlPhotos.Add(photo.PictureNormalURL);
                }
            }
            else
            {
                foreach (Photo photo in m_LoggedInUser.Albums[selectedAlbumIndex].Photos)
                {
                    m_CurrentAlbumUrlPhotos.Add(photo.PictureNormalURL);
                }
            }
        }

        private void onChangeSelectedAlbum(object sender, EventArgs e)
        {
            m_CurrentAlbumUrlPhotos.Clear();
            getCurrentAlbumPhotosURL();
            m_CurrentPhotoIndex = 0;
            displayPhoto();
        }

        private void fetchAlbumsNames()
        {
            foreach (Album album in m_LoggedInUser.Albums)
            {
                m_AlbumsNamesListBox.Items.Add(album.Name);
            }

            m_AlbumsNamesListBox.Items.Add("Photos of You");
        }

        private void m_NextPhoto_Click(object sender, EventArgs e)
        {
            if (m_CurrentPhotoIndex == m_CurrentAlbumUrlPhotos.Count - 1)
            {
                m_CurrentPhotoIndex = 0;
            }
            else
            {
                m_CurrentPhotoIndex++;
            }

            m_CurrentPhotoPictureBox.Load(m_CurrentAlbumUrlPhotos[m_CurrentPhotoIndex]);
        }
        //
        private void m_PreviousPhoto_Click(object sender, EventArgs e)
        {
            if (m_CurrentPhotoIndex == 0)
            {
                m_CurrentPhotoIndex = m_CurrentAlbumUrlPhotos.Count - 1;
            }
            else
            {
                m_CurrentPhotoIndex--;
            }

            m_CurrentPhotoPictureBox.Load(m_CurrentAlbumUrlPhotos[m_CurrentPhotoIndex]);
        }
    }
}
