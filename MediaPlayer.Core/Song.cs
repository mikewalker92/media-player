namespace MediaPlayer.Core
{
    using System;
    using System.Windows.Media;

    public class Song
    {
        private MediaPlayer player;

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
            GetMetadata();
            player = new MediaPlayer();
            player.Open(new Uri(FileLocation));
        }

        public void Play()
        {
            player.Play();
            IncrementPlays();
        }

        public void Pause()
        {
            player.Pause();
        }

        public void Stop()
        {
            player.Stop();
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
            FileLocation = @"E:\paradise.wav";
        }
    }
}
