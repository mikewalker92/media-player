namespace MediaPlayer.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Artist
    {
        public String ArtistId { get; set; }

        public String Name { get; set; }

        public List<Track> Tracks { get; set; }
    }
}
