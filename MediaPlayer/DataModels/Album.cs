namespace MediaPlayer.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Album
    {
        public String AlbumId { get; set; }

        public String Title { get; set; }

        public Artist PrimaryArtist { get; set; }

        public List<Artist> Artists { get; set; }

        public List<Track> Tracks { get; set; }
    }
}
