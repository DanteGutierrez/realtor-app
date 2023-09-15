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

            builder.Services.AddSingleton<ListingService>();
            builder.Services.AddSingleton<ListingsViewModel>();
            builder.Services.AddSingleton<MainPage>();


#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}