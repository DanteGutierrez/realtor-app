using RealtorApp.ViewModels;

namespace RealtorApp;

public partial class ListingDetailsPage : ContentPage
{
	public ListingDetailsPage(ListingDetailsViewModel viewmodel)
	{
		InitializeComponent();

		BindingContext = viewmodel;
	}
}