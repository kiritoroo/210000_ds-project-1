using System;
using System.Drawing;

namespace MediaPlayer.Objects
{
    public class Song
    {
        public string filePath { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public TimeSpan duration { get; set; }
        public Image image { get; set; }
        public Song()
        {

        }
        public Song(string _filePath, string _title, string _year, TimeSpan _duration, Image _image)
        {
            this.filePath = _filePath; ;
            this.title = _title;
            this.year = _year;
            this.duration = _duration;
            image = _image;
        }
    }
}
