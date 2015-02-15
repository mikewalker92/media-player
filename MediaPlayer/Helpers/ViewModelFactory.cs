namespace MediaPlayer.Helpers
{
    using Caliburn.Micro;

    public interface IViewModelFactory
    {
        T Get<T>();
    }

    public class ViewModelFactory : IViewModelFactory
    {
        public T Get<T>()
        {
            return IoC.Get<T>();
        }
    }
}
