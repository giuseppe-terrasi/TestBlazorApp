
namespace TestBlazorApp
{
    public class NotificationService : INotificationService
    {
        public event EventHandler<bool> LoadingStateChanged;

        public async void NotifyLoading(bool isLoading)
        {
            await Task.Delay(100);
            LoadingStateChanged?.Invoke(null, isLoading);
        }
    }
}
