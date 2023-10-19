using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Web;

namespace WCF
{
    [DataContract]
    public class Music
    {
        Regex regex = new Regex(@"\s{2,}");

        public Music()
        {

        }

        public Music(string Name, string Artist, string Album, Genres Genre, int Likes, int Dislikes)
        {
            this.Name = Name;
            this.Artist = Artist;
            this.Album = Album;
            this.Genre = Genre;
            this.Likes = Likes;
            this.Dislikes = Dislikes;
        }

        [DataMember]
        public int Id { get; set; }

        private string name;

        [DataMember]
        public string Name
        {
            get { return name; }
            set 
            {
                if (value == null)
                    throw new Exception("Kérem adjon meg egy nevet!");
                if (value.Trim().Length < 2)
                    throw new Exception("A zene neve nem lehet rövidebb 2 karakternél!");
                if (regex.IsMatch(value))
                    throw new Exception("Nem lehet kettő space egymás mellett!");
                name = value; 
            }
        }

        private string artist;

        [DataMember]
        public string Artist
        {
            get { return artist; }
            set 
            {
                if (value == null)
                    throw new Exception("Kérem adjon meg egy előadót!");
                if (value.Trim().Length < 2)
                    throw new Exception("Az előadó nem lehet rövidebb 2 karakternél!");
                if (regex.IsMatch(value))
                    throw new Exception("Nem lehet kettő space egymás mellett!");
                artist = value; 
            }
        }

        private string album;

        [DataMember]
        public string Album
        {
            get { return album; }
            set 
            {
                if (value == null)
                    throw new Exception("Kérem adjon meg egy album nevet!");
                if (value.Trim().Length < 2)
                    throw new Exception("Az album nem lehet rövidebb 2 karakternél!");
                if (regex.IsMatch(value))
                    throw new Exception("Nem lehet kettő space egymás mellett!");
                album = value; 
            }
        }

        private Genres genre;

        [DataMember]
        public Genres Genre
        {
            get { return genre; }
            set 
            {
                if (value == Genres.NONE)
                    throw new Exception("Kérem válasszon műfajt!");
                genre = value; 
            }
        }

        private int likes;

        [DataMember]
        public int Likes
        {
            get { return likes; }
            set { likes = value; }
        }

        private int dislikes;

        [DataMember]
        public int Dislikes
        {
            get { return dislikes; }
            set { dislikes = value; }
        }
    }
}