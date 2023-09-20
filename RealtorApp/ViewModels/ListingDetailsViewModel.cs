using CommunityToolkit.Mvvm.ComponentModel;
using RealtorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorApp.ViewModels
{
    [QueryProperty("Listing", "Listing")]
    public partial class ListingDetailsViewModel : BaseViewModel
    {
        public ListingDetailsViewModel() 
        { 
        }

        [ObservableProperty]
        private Listing listing;
    }
}
