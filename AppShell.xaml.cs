namespace LedgerDemo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ProductSelectionPage), typeof(ProductSelectionPage));
        }
    }
}
