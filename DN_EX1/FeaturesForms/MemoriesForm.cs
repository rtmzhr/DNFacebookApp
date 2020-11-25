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
    public partial class MemoriesForm : Form
    {
        private User m_LoggedInUser;
        private List<string> m_PhotosListURL = new List<string>();
        private int m_CurrentPhotoIndex;

        public MemoriesForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            fetchFriends();
            m_DatePicker.ValueChanged += OnDatePick;
            m_FriendsListBox.SelectedIndexChanged += OnFriendPick;
        }


        private void OnFriendPick(object sender, EventArgs e)
        {
            fetchMemories(sender);
        }

        private void fetchMemories(object i_Sender)
        {
            fetchPosts(i_Sender);
            fethPhotos(i_Sender);
            fetchPlaces(i_Sender);
            fetchEvents(i_Sender);
        }

        private void fetchEvents(object i_Sender)
        {
            if (i_Sender is DateTimePicker)
            {
                DateTime datePicked = (i_Sender as DateTimePicker).Value;
                foreach (Event evnt in m_LoggedInUser.Events)
                {
                    if (evnt.AttendingUsers.Contains(m_LoggedInUser) && evnt.StartTime.Value.Date == datePicked.Date)
                    {
                        m_EventsListBox.Items.Add(evnt.Name);
                    }
                }
            }
            else if (i_Sender is ListBox)
            {
                User friendPicked = m_LoggedInUser.Friends[(i_Sender as ListBox).SelectedIndex];
                foreach (Event evnt in m_LoggedInUser.Events)
                {
                    if (evnt.AttendingUsers.Contains(m_LoggedInUser) && evnt.AttendingUsers.Contains(friendPicked))
                    {
                        m_EventsListBox.Items.Add(evnt.Name + "- " + evnt.StartTime.Value.Date);
                    }
                }
            }
        }

        private void fetchFriends()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                m_FriendsListBox.Items.Add(friend.Name);
            }
        }

        private void OnDatePick(object sender, EventArgs e)
        {
            fetchMemories(sender);

        }

        private void fetchPlaces(object sender)
        {
            m_PlacesCheckedInListBox.Items.Clear();
            if (sender is DateTimePicker)
            {
                DateTime datePicked = (sender as DateTimePicker).Value;
                foreach (Checkin checkin in m_LoggedInUser.Checkins)
                {
                    if (checkin.CreatedTime.Value.Date == datePicked.Date)
                    {
                        m_PlacesCheckedInListBox.Items.Add(checkin.Place.Name);
                    }
                }
            }
            else if (sender is ListBox)
            {
                string pickedFriendName = (sender as ListBox).SelectedItem.ToString();
                foreach (Checkin checkin in m_LoggedInUser.Checkins)
                {
                    foreach (User taggedFriend in checkin.TaggedUsers)
                    {
                        if (taggedFriend.Name == pickedFriendName)
                        {
                            m_PlacesCheckedInListBox.Items.Add(checkin.Place.Name);
                        }
                    }
                }

            }
        }

        private void fethPhotos(object i_Sender)
        {
            m_PhotosListURL.Clear();
            m_PhotoPictureBox.Image = null;
            m_CurrentPhotoIndex = 0;
            if (i_Sender is DateTimePicker)
            {
                DateTime datePicked = (i_Sender as DateTimePicker).Value;
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        if (photo.CreatedTime.Value.Date == datePicked.Date)
                        {
                            m_PhotosListURL.Add(photo.PictureNormalURL);
                        }
                    }
                }

                foreach (Photo photo in m_LoggedInUser.PhotosTaggedIn)
                {
                    if (photo.CreatedTime.Value.Date == datePicked.Date)
                    {
                        m_PhotosListURL.Add(photo.PictureNormalURL);
                    }
                }

                if (m_PhotosListURL.Count > 0)
                {
                    m_PhotoPictureBox.Load(m_PhotosListURL[0]);
                }
            }
            else if (i_Sender is ListBox)
            {
                string pickedFriendName = (i_Sender as ListBox).SelectedItem.ToString();
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        if (photo.Tags != null) //ALWAYS NULLL!!
                        {
                            foreach (PhotoTag tags in photo.Tags)
                            {
                                if (tags.User.Name == pickedFriendName)
                                {
                                    m_PhotosListURL.Add(photo.PictureNormalURL);
                                }
                            }
                        }
                    }
                }

                foreach (Photo photo in m_LoggedInUser.PhotosTaggedIn)
                {
                    if (photo.Tags != null)
                    {
                        foreach (PhotoTag tags in photo.Tags)
                        {
                            if (tags.User.Name == pickedFriendName)
                            {
                                m_PhotosListURL.Add(photo.PictureNormalURL);
                            }
                        }
                    }
                }
            }

            updateNumberOfPhotosLabale();
        }

        private void updateNumberOfPhotosLabale()
        {
            m_NumberOfPhotosLabal.Visible = true;
            int currentPhoto = 0;
            if (m_PhotosListURL.Count > 0)
            {
                currentPhoto = m_CurrentPhotoIndex + 1;

            }

            m_NumberOfPhotosLabal.Text = currentPhoto + "/" + m_PhotosListURL.Count;
        }

        private void fetchPosts(object i_Sender)
        {
            m_Posts.Items.Clear();
            if (i_Sender is DateTimePicker)
            {
                DateTime datePicked = (i_Sender as DateTimePicker).Value;
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.CreatedTime.Value.Date == datePicked.Date)
                    {
                        addPostToListBox(post);
                    }
                }
            }
            /* else if(sender is ListBox) //                                             IN SOME POSTS THERE IS NO TAGGEDUSERS
             {
                 string pickedFriendName = (sender as ListBox).SelectedItem.ToString();
                 foreach(Post post in m_LoggedInUser.Posts)
                 {                    
                     if (post.TaggedUsers != null)
                     {
                         foreach (User taggedFriend in post.TaggedUsers)
                         {
                             if (taggedFriend.Name == pickedFriendName)
                             {
                                 addPostToListBox(post);
                             }
                         }
                     }                    
                 }
             }*/

        }

        private void addPostToListBox(Post i_Post)
        {
            if (i_Post.Description != null)
            {
                m_Posts.Items.Add(i_Post.Description);
            }

            if (i_Post.Caption != null)
            {
                m_Posts.Items.Add(i_Post.Caption);
            }
        }

        private void m_DateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (m_DateRadioButton.Checked)
            {
                m_DatePicker.Visible = true;
                updateDateModeLabels();
            }
            else
            {
                m_DatePicker.Visible = false;
            }
        }

        private void updateDateModeLabels()
        {
            m_PostsLabel.Text = "Your posts at this day";
            m_PictureLabel.Text = "Your pictures at this day";
            m_PlacesLabel.Text = "You cheked in those places at this day";
            m_EventsLabel.Text = "You atteded those events at this day";
            ;
        }

        private void m_FriendRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (m_FriendRadioButton.Checked)
            {
                m_FriendsListBox.Visible = true;
                updateFriendModeLabels();
            }
            else
            {
                m_FriendsListBox.Visible = false;
            }
        }

        private void updateFriendModeLabels()
        {
            m_PostsLabel.Text = "Yours common posts by tagging";
            m_PictureLabel.Text = "Yours common pictures by tagging";
            m_PlacesLabel.Text = "Yours common places by tagging";
            m_EventsLabel.Text = "Yours common attended events";
        }

        // DUPLICATE CODE FROM ALBUMS FORMS!!!!
        private void m_RightPhoto_Click(object sender, EventArgs e)
        {
            if (m_PhotosListURL.Count > 0)    // CAN SWITCH TO BUTTON.ENABLED- FALSE WHEN THE LIST IS EMPTY TO HANDLE THIS PROBLEM            
            {
                if (m_CurrentPhotoIndex == m_PhotosListURL.Count - 1)
                {
                    m_CurrentPhotoIndex = 0;
                }
                else
                {
                    m_CurrentPhotoIndex++;
                }

                m_PhotoPictureBox.Load(m_PhotosListURL[m_CurrentPhotoIndex]);
                updateNumberOfPhotosLabale();
            }
        }

        private void m_LeftPhoto_Click(object sender, EventArgs e)
        {
            if (m_PhotosListURL.Count > 0)
            {
                if (m_CurrentPhotoIndex == 0)
                {
                    m_CurrentPhotoIndex = m_PhotosListURL.Count - 1;
                }
                else
                {
                    m_CurrentPhotoIndex--;
                }

                m_PhotoPictureBox.Load(m_PhotosListURL[m_CurrentPhotoIndex]);
                updateNumberOfPhotosLabale();
            }
        }
    }
}
