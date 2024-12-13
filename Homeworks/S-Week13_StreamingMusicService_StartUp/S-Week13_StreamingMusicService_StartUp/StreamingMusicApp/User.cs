using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public class User
    {
        private const int MaxSongsInFavs = 50;

        private string Username;
        private string Name;
        private string Email;
        private List<Song> FavSongs { get; set; }
        private List<Song> AllSongs { get; set; }


        public User(string username, string email)
        {
            this.Username = username;
            this.Email = email;
            FavSongs = new List<Song>(); //yo did you know you don't need to put it in the constructor? it works anyway? it makes a list anyway? wow!
            AllSongs = new List<Song>();
        }


        public void AddSongToFavorites(Song song)
        {

            if (FavSongs.Count < MaxSongsInFavs)
            {
                FavSongs.Add(song);
            }
            else
            {
                MessageBox.Show("Limit Excedded!");
            }
        }
        public void RemoveSongFromFavorites(Song song)
        {
            if (FavSongs.Count == 0)
            {
                MessageBox.Show("There are no more songs!");
            }
            if (!FavSongs.Contains(song))
            {
                MessageBox.Show("That song is not there anymore");
            }
            else
            {
                FavSongs.Remove(song);
            }

        }
        public string GetUsername()
        {
            return this.Username;
        }

        public string GetFavoriteSongs()
        {
            List<string> favoritesongs = new List<string>();
            foreach (Song s in FavSongs)
            {
                favoritesongs.Add(s.GetInfo());

            }
            return $"List of Favorite songs of {Username}: \n {string.Join("\n", favoritesongs)}";
        }
        public string GetFavoriteSongs(Genre genre)
        {
            List<string> favoritesongs = new List<string>();
            
            foreach (Song s in FavSongs)
            {
                
                favoritesongs.Add(s.GetInfoGenre());

            }
            return $"List of Favorite songs of {Username}: \n {string.Join("\n", favoritesongs)}";
        }
        public int GetAllSongs()
        {
            return AllSongs.Count;
        }
        
    }

      

   
}
