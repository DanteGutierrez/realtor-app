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

        public ListingsViewModel(ListingService listingService) 
        {
            Title = "Home";

            this.listingService = listingService;
        }

        [RelayCommand]
        private async Task GetListingsAsync()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;

                List<Listing> listings = await listingService.GetListingsAsync();

                if (Listings.Count != 0) Listings.Clear();

                foreach(Listing listing in listings) 
                {
                    Listings.Add(listing);
                }
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
