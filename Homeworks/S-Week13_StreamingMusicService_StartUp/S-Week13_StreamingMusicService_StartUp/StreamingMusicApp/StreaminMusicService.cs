using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class StreamingMusicService
    {
        private int songIdSeeder;
        private string name;
        private List<Song> songs;
        public List<User> UserList;
        
        
        

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.name = name;
            this.songs = new List<Song>();
            this.UserList = new List<User>();
            
        }

        public void AddSong(string artist, string title, double durationInSeconds)
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds));
            this.songIdSeeder++;
        }
        public void AddSong(string artist, string title, double  durationInSeconds, Genre Genre )
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds, Genre));
            this.songIdSeeder++;
        }

        public Song GetSong(int id)
        {
            foreach (Song s in this.songs)
            {
                if (id == s.GetId())
                { 
                    return s; 
                }
            }
            return null;
        }

        public Song[] GetSongs() 
        {
            return this.songs.ToArray();  //ew arrays How can I make a editable playlist with this?
        }

        public Song[] GetSongs(string artist)
        {
            List<Song> foundSongs = new List<Song>();
            foreach (Song s in this.songs)
            {
                if(artist == s.GetArtist())
                { foundSongs.Add(s); }
            }
            return foundSongs.ToArray(); //ew arrays
        }

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.songs.Count} songs)";
        }
       
        public void AddUser(User user)
        {
            UserList.Add(user);
        }

        public string GetUser(string username)
        {
            return username;
        }

        public List<User> GetUsers(List<User> userlist)
        {
            return userlist;
        }
        //public string GetUserInfo() //also include number of users
        //{
        //    List<string> usernames = new List<string>();

        //    foreach (User user in UserList)
        //    {
        //        usernames.Add(user.GetUsername());
        //    }
        //    return $"Nr of users: {UserList.Count} \n All Users: {string.Join("\n", usernames)} ";
        //}
    }
}
