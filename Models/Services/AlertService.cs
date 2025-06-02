namespace ComputerComponentShop.Models.Services
{
    public class AlertService
    {
        public event Action<string>? OnShow;

        public async Task ShowAsync(string aMessage)
        {
            OnShow?.Invoke(aMessage);

        }

    }
}
