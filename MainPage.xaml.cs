namespace LedgerDemo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Event handler for the "Get Started" button click
    private void OnGetStartedClicked(object sender, EventArgs e)
    {
        // Show the sidebar grid
        SidebarGrid.IsVisible = true;
    }

    // Event handler for the "Refuse all" button on the new sidebar
    private void OnRefuseAllClicked(object sender, EventArgs e)
    {
        // Hide the sidebar grid
        SidebarGrid.IsVisible = false;
    }

    // Event handler for the "Accept all" button on the new sidebar
    private async void OnAcceptAllClicked(object sender, EventArgs e)
    {
        // Hide the sidebar grid
        SidebarGrid.IsVisible = false;

        // Navigate to the new ProductSelectionPage
        await Shell.Current.GoToAsync(nameof(ProductSelectionPage));
    }
}