using Microsoft.Maui.Controls;

namespace LedgerDemo
{
    public partial class ProductDetailsPage : ContentPage
    {
        public ProductDetailsPage()
        {
            InitializeComponent();
        }

        private async void OnPreviousClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private async void OnStartSetupClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SetupPage));
        }

        private async void OnRestoreClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SetupPage));
        }

        private async void OnConnectClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SetupPage));
        }
    }
}