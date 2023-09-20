using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealtorApp.Models;
using RealtorApp.Services;
using System.Collections.ObjectModel;

namespace RealtorApp.ViewModels
{
    public partial class ListingsViewModel : BaseViewModel
    {
        private ListingService listingService;

        public ObservableCollection<Listing> Listings { get; } = new();

        private IConnectivity connectivity;

        [ObservableProperty]
        private bool noListings = true;


        public ListingsViewModel(ListingService listingService, IConnectivity connectivity) 
        {
            this.listingService = listingService;
            this.connectivity = connectivity;
        }

        [RelayCommand]
        private async Task GoToDetailsAsync(Listing listing)
        {
            if (listing is null) return;

            await Shell.Current.GoToAsync(nameof(ListingDetailsPage), true,
                new Dictionary<string, object>
                {
                    {"Listing", listing }
                });
        }
        private bool CanGetListings() { return IsNotBusy; }
        [RelayCommand(CanExecute=nameof(CanGetListings))]
        private async Task GetListingsAsync()
        {
            try
            {
                if(connectivity.NetworkAccess != NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("Internet Issue", "Check your internet connection and try again", "OK");
                    return;
                }

                List<Listing> listings = await listingService.GetListingsAsync();

                if (Listings.Count != 0) Listings.Clear();

                foreach(Listing listing in listings) 
                {
                    Listings.Add(listing);
                }

                if (Listings.Count > 0) NoListings = false;
                else NoListings = true;
            }
            catch
            {
                // TODO
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
