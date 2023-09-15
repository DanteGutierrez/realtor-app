using RealtorApp.ViewModels;

namespace RealtorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(ListingsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}