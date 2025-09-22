namespace LedgerDemo;

public partial class ProductSelectionPage : ContentPage
{
    public ProductSelectionPage()
    {
        InitializeComponent();
    }

    // Event handler for pointer entering a product item
    private async void OnPointerEntered(object sender, PointerEventArgs e)
    {
        if (sender is Grid grid)
        {
            var image = grid.Children.OfType<Image>().FirstOrDefault();
            var button = grid.Children.OfType<Button>().FirstOrDefault();

            if (image != null && button != null)
            {
                await image.TranslateTo(0, -20, 150, Easing.CubicOut);
                button.IsVisible = true;
            }
        }
    }

    // Event handler for pointer exiting a product item
    private async void OnPointerExited(object sender, PointerEventArgs e)
    {
        if (sender is Grid grid)
        {
            var image = grid.Children.OfType<Image>().FirstOrDefault();
            var button = grid.Children.OfType<Button>().FirstOrDefault();

            if (image != null && button != null)
            {
                // Animate the image back to its original position
                await image.TranslateTo(0, 0, 150, Easing.CubicIn);

                button.IsVisible = false;
            }
        }
    }
}