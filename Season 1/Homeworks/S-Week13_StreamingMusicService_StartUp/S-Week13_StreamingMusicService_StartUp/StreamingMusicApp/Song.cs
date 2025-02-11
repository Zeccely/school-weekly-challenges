using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class Song
    {
        private int id;
        private string artist;
        private string title;        
        private double durationInSeconds;
        private Genre genreS;

        public Song(int id, string artist, string title, double durationInSeconds)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.durationInSeconds = durationInSeconds;
            
        }
        public Song(int id, string artist, string title, double durationInSeconds, Genre genre)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.durationInSeconds = durationInSeconds;
            this.genreS = genre;
        }
        //public Song(string artist, string title, double durationInSeconds, Genre genre)
        //{
        //    this.id = 0;
        //    this.artist = artist;
        //    this.title = title;
        //    this.durationInSeconds = durationInSeconds;
        //    this.genreS = genre;
        //}

        public int GetId()
        { return this.id; }

        public string GetArtist()
        { return this.artist; }

        public string GetTitle() 
        { return this.title; }

        public double GetDuration() 
        {  return this.durationInSeconds; }

        public string GetInfo()
        {
            return $"ID {this.id:00}: {this.artist} - {this.title} ({this.durationInSeconds} seconds)";
        }
        public string GetInfoGenre()
        {
            return $"Genre: ({this.genreS}) ID {this.id:00} : {this.artist} - {this.title} ({this.durationInSeconds} seconds) ";
        }
        public override string ToString()
        {
            return $"{this.genreS}: {this.artist} - {this.title} ({this.durationInSeconds} seconds) ";
        }

        public Genre GetGenre()
        {
            return this.genreS;
        }
    }
    public enum Genre
    {
        Classic,
        Dance,
        KPop,
        JRock,
    }
}
