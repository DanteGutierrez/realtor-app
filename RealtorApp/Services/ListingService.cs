using RealtorApp.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace RealtorApp.Services
{
    public class ListingService
    {
        //HttpClient httpClient;

        public ListingService()
        {
            //httpClient = new HttpClient();
        }

        List<Listing> listings = new();
        
        public async Task<List<Listing>> GetListingsAsync()
        {

            //string url = "";

            //HttpResponseMessage response = await httpClient.GetAsync(url);

            //if (response.IsSuccessStatusCode)
            //{
            //    listings = await response.Content.ReadFromJsonAsync<List<Listing>>();
            //}

            using Stream stream = await FileSystem.OpenAppPackageFileAsync("listingdata.json");

            using StreamReader reader = new StreamReader(stream);

            string contents = await reader.ReadToEndAsync();

            listings = JsonSerializer.Deserialize<List<Listing>>(contents);

            return listings;
        }
    }
}
