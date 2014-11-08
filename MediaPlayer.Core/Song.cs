
namespace MediaPlayer.Core
{
    public class Song
    {
        private ISongPlayer songPlayer;

#region Properties

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public string Length { get; set; }

        public int NumberOfPlays { get; private set; }

        public string FileLocation { get; set; }

#endregion

        public Song()
        {
            this.songPlayer = new SongPlayer();
            GetMetadata();
        }

        public void Play()
        {
            songPlayer.Play(FileLocation);
            IncrementPlays();
        }

        private void IncrementPlays()
        {
            NumberOfPlays += 1;
        }

        private void GetMetadata()
        {
            Title = "Paradise";
            Artist = "Coldplay";
            Album = "Mylo Xyloto";
        }
    }
}
