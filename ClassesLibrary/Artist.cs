using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields
        //props
        public Song[] Song { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //ctor
        public Artist(Song[] song, string title, string genre)
        {
            Song = song;
            Title = title;
            Genre = genre;
        }
        public Artist() { }
        
        //methods
        public override string ToString()
        {
            return string.Format("Song: '{0}'\n" +
                "Title: {1}\n" +
                "Genre: {2}",
                Song, Title, Genre);
        }
    }
}
