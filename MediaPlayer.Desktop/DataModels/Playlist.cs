namespace MediaPlayer.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Playlist
    {
        public List<Track> Tracks { get; set; }

        public String Name { get; set; }

        public Playlist()
        {
            Tracks = new List<Track>();
        }
    }
}
