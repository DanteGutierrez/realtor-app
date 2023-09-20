
using RealtorApp.ViewModels;

namespace RealtorApp
{
    public partial class AppShell : Shell
    {

        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ListingDetailsPage), typeof(ListingDetailsPage));
        }
    }
}