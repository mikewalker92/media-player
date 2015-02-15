namespace MediaPlayer.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Track
    {
        public string TrackId { get; set; }

        public string Title { get; set; }

        public Artist PrimaryArtist { get; set; }

        public List<Artist> Artists { get; set; }

        public Album Album { get; set; }

        public string Image { get; set; }  

        public Track()
        {
            Artists = new List<Artist>();
        }
    }
}
