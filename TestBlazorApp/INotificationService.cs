namespace TestBlazorApp
{
    public interface INotificationService
    {
        public void NotifyLoading(bool isLoading);

        public event EventHandler<bool> LoadingStateChanged;
    }
}
