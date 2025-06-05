namespace ComputerComponentShop.Models.Services
{
    public class AlertService
    {
        public event Action<string>? OnShow; //When a alert message should display to the user

        /// <summary>
        /// Triggers the OnShow event to display a alert with a message
        /// </summary>
        /// <param name="aMessage"></param>
        /// <returns></returns>
        public async Task ShowAsync(string aMessage)
        {
            OnShow?.Invoke(aMessage);

        }

    }
}
