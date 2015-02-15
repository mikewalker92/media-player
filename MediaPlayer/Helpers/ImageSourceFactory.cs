namespace MediaPlayer.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using System.Windows.Media;
    using System.Windows.Media.Imaging;

    public interface IImageSourceFactory
    {
        ImageSource GetForUrl(string url);
    }

    public class ImageSourceFactory : IImageSourceFactory
    {
        public ImageSource GetForUrl(string url)
        {
            return new BitmapImage(new Uri(url, UriKind.Absolute));
        }
    }
}
