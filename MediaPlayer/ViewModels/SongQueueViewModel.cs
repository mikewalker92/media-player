namespace MediaPlayer.ViewModels
{
    using Caliburn.Micro;
    using MediaPlayer.DataModels;
    using MediaPlayer.Helpers;

    public class SongQueueViewModel : Conductor<TrackViewModel>.Collection.AllActive
    {
        private IViewModelFactory viewModelFactory;

        public SongQueueViewModel(IViewModelFactory viewModelFactory)
        {
            // TODO - this method should not create a playlist.
            this.viewModelFactory = viewModelFactory;
            var playlist = CreatePlaylist();
            AddPlaylist(playlist);
        }

        public void AddPlaylist(Playlist playlist)
        {
            foreach (var track in playlist.Tracks)
            {
                var trackViewModel = viewModelFactory.Get<TrackViewModel>();
                trackViewModel.Track = track;
                AddTrackView(trackViewModel);
            }
        }

        public void AddTrackView(TrackViewModel trackViewModel)
        {
            Items.Add(trackViewModel);
        }

        private Playlist CreatePlaylist()
        {
            var playlist = new Playlist();
            for (var i = 0; i < 20; i++)
            {
                var album = new Album();
                album.Title = "1000 Forms of Fear";
                var track = new Track();
                track.Image = "E:/Music/MediaPlayer/AlbumArt/exampleImage.png";
                track.Album = album;
                var sia = new Artist();
                sia.Name = "Sia";
                track.Artists.Add(sia);
                track.Title = "Elastic Heart";
                track.PrimaryArtist = sia;
                playlist.Tracks.Add(track);
            }
            return playlist;
        }
    }
}
