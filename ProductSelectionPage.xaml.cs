namespace LedgerDemo;

public partial class ProductSelectionPage : ContentPage
{
    public ProductSelectionPage()
    {
        InitializeComponent();
    }

    private async void OnPointerEntered(object sender, PointerEventArgs e)
    {
        if (sender is Grid grid)
        {
            var image = grid.Children.OfType<Image>().FirstOrDefault();
            var button = grid.Children.OfType<Button>().FirstOrDefault();

            if (image != null && button != null)
            {
                grid.BackgroundColor = Color.FromHex("#16161a");
                await image.TranslateTo(0, -20, 150, Easing.CubicOut);
                button.IsVisible = true;
            }
        }
    }

    private async void OnPointerExited(object sender, PointerEventArgs e)
    {
        if (sender is Grid grid)
        {
            var image = grid.Children.OfType<Image>().FirstOrDefault();
            var button = grid.Children.OfType<Button>().FirstOrDefault();

            if (image != null && button != null)
            {
                grid.BackgroundColor = Color.FromHex("#0e0e11");
                await image.TranslateTo(0, 0, 150, Easing.CubicIn);
                button.IsVisible = false;
            }
        }
    }

    private async void OnProductSelected(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            string productName = string.Empty;

            // Get the parent Grid and find the Label with the product name
            if (button.Parent is Grid parentGrid)
            {
                var label = parentGrid.Children.OfType<Label>().FirstOrDefault();
                if (label != null)
                {
                    productName = label.Text;
                }
            }

            if (!string.IsNullOrEmpty(productName))
            {
                var navigationParameter = new Dictionary<string, object>
                {
                    { "ProductName", productName }
                };
                await Shell.Current.GoToAsync(nameof(ProductDetailsPage), navigationParameter);
            }
        }
    }
}