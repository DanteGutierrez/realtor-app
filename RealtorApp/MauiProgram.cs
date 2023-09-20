using Microsoft.Extensions.Logging;
using RealtorApp.Services;
using RealtorApp.ViewModels;

namespace RealtorApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
            builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
            builder.Services.AddSingleton<IMap>(Map.Default);

            builder.Services.AddSingleton<ListingService>();

            builder.Services.AddSingleton<ListingsViewModel>();
            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddTransient<ListingDetailsViewModel>();
            builder.Services.AddTransient<ListingDetailsPage>();

            builder.Services.AddSingleton<FilterPage>();

            builder.Services.AddSingleton<MessagesPage>();

            builder.Services.AddSingleton<ProfilePage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}