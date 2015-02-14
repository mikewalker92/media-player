namespace MediaPlayer.ViewModels
{
    using Caliburn.Micro;
    using System.Windows.Controls;
    using System.Data;

    public class TrackListViewModel : Screen
    {
        private DataTable _trackData;

#region Properties
        public DataTable TrackData
        {
            get
            {
                return _trackData;
            }

            set
            {
                _trackData = value;
                NotifyOfPropertyChange(() => TrackData);
            }
        }
#endregion

        public TrackListViewModel()
        {
            CreateTable();
            PopulateTrackList();
        }

        private void CreateTable()
        {
            TrackData = new DataTable();
            TrackData.Columns.Add(new DataColumn("Title", typeof(string)));
            TrackData.Columns.Add(new DataColumn("Artist", typeof(string)));
            TrackData.Columns.Add(new DataColumn("Album", typeof(string)));
            TrackData.Columns.Add(new DataColumn("Length", typeof(string)));
            TrackData.Columns.Add(new DataColumn("Plays", typeof(string)));
        }

        private void PopulateTrackList()
        {
            // TODO - this method os obviously not finished!
            for (var counter = 0; counter < 100; counter++)
            {
                var row = TrackData.NewRow();
                row["Title"] = "Elastic Heart";
                row["Artist"] = "Sia";
                row["Album"] = "1000 Forms of Fear";
                row["Length"] = "5:04";
                row["Plays"] = "17";
                TrackData.Rows.Add(row);
            }
        }
    }
}
