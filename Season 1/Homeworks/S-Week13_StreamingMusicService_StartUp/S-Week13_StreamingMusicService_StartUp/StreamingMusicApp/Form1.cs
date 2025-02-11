using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public partial class Form1 : Form //Ahhhhh I don't know how to connect this properly!
    {
        StreamingMusicService Musicity = new StreamingMusicService("Bobusico");
        User musiclistener;

        public Form1()
        {
            InitializeComponent();
            songusercounterlbl.Text = $"Users: {Musicity.UserList.Count} Songs: {Musicity.Songs.Count}";
            songGenre.DataSource = Enum.GetNames(typeof(Genre));
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void createUser_Click(object sender, EventArgs e) // try to prevent repeat usernames
        {
            string usernamenow = usernametbx.Text.ToString();
            string emailnow = emailtbx.Text.ToString();
            musiclistener = new User(usernamenow, emailnow);

            if (usernamenow == string.Empty || emailnow == string.Empty)
            {
                MessageBox.Show("Do not add empty usernames or emails");
                return;
            }

            if (Musicity.UsernameCheck(usernamenow) == false)
            {
                Musicity.AddUser(musiclistener);
            }
            else
            {
                MessageBox.Show("Username taken");
                return;
            }

            
            songusercounterlbl.Text = $"Users: {Musicity.UserList.Count} Songs: {Musicity.Songs.Count}";

            userlistview.Items.Clear();
            artisttbx.Text = string.Empty;
            titletbx.Text = string.Empty;
            durationsectbx.Value = 0;



            foreach (User user in Musicity.UserList)
            {
                userlistview.Items.Add(user);

            }


        }

        private void addSongs_Click(object sender, EventArgs e)
        {
            userSongs.Items.Clear();
            string artist = artisttbx.Text.ToString();
            string title = titletbx.Text.ToString();
            double duration = Convert.ToDouble(durationsectbx.Text);
            string genre = songGenre.SelectedItem.ToString();
            Genre songtype = (Genre)Enum.Parse(typeof(Genre), genre); //this can be a problem
            Song track = Musicity.AddSong(artist, title, duration, songtype);
            songusercounterlbl.Text = $"Users: {Musicity.UserList.Count} Songs: {Musicity.Songs.Count}";

            //if (Musicity.SongCheck(track) == true)
            //{
            //    how do I copy it and give the same song to two users?
            //}

            if (musiclistener != null)
            {
                musiclistener.AllSongs.Add(track);

            }
            foreach (Song song in musiclistener.AllSongs)
            {
                userSongs.Items.Add(song);
            }
            artisttbx.Text = string.Empty;
            titletbx.Text = string.Empty;
            durationsectbx.Value = 0;


        }

        private void favoriteadder_Click(object sender, EventArgs e)
        {
            Song Songtobeadded;

            if (musiclistener == null)
            {
                MessageBox.Show("Add a person first");
                return;
            }

            if (userSongs.SelectedItem != null)
            {
                Songtobeadded = (Song)userSongs.SelectedItem;
                musiclistener.AddSongToFavorites(Songtobeadded);
            }

            favoritesongs.Items.Clear();
            foreach (Song favoritesong in musiclistener.FavSongs)
            {
                favoritesongs.Items.Add(favoritesong.ToString());
            }

        }

        private void userswitcher_Click(object sender, EventArgs e)
        {
            User currentuser = (User)userlistview.SelectedItem; //complaint about system string to streamingmusicapp

            musiclistener = currentuser;

            userSongs.Items.Clear();
            favoritesongs.Items.Clear();
            artisttbx.Text = string.Empty;
            titletbx.Text = string.Empty;
            durationsectbx.Value = 0;

        }

        private void allsongsrefreshbtn_Click(object sender, EventArgs e)
        {
            userSongs.Items.Clear();
            foreach (Song song in musiclistener.AllSongs)
                if (musiclistener.AllSongs.Contains(song))
                {
                    {
                        userSongs.Items.Add(song);
                    }
                }
        }

        private void favrefreshbtn_Click(object sender, EventArgs e)
        {
            favoritesongs.Items.Clear();
            foreach (Song song in musiclistener.FavSongs)
                if (musiclistener.FavSongs.Contains(song))
                {
                    {
                        favoritesongs.Items.Add(song);
                    }
                }
        }

        private void allsongsbtn_Click(object sender, EventArgs e)
        {
            allSongslbx.Items.Clear();
            foreach (Song song in Musicity.Songs)
            {
                allSongslbx.Items.Add(song);
            }
        }
    }
}
