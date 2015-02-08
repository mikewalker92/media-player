namespace MediaPlayer.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Track
    {
        public String TrackId { get; set; }

        public String Title { get; set; }

        public Artist PrimaryArtist { get; set; }

        public List<Artist> Artists { get; set; }
    }
}
