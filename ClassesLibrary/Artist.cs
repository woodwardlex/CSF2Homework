using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields
        //props
        public Song[] Songs { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //ctor
        public Artist(Song[] songs, string title, string genre)
        {
            Songs = songs;
            Title = title;
            Genre = genre;
        }
        public Artist() { }
        
        //methods
        public override string ToString()
        {
            return string.Format("Title: '{0}'\n" +
                "Genre: {1}\n" +
                "Song: {2}",
                Title, Genre, Songs);
        }
    }
}
