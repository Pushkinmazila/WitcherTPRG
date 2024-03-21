using Microsoft.Extensions.Logging;
using SQLite;
using static MauiApp7.MainPage;
//using UraniumUI;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Storage;

namespace MauiApp7
{

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                //.UseUraniumUI()
                .UseMauiCommunityToolkit()
                //.UseUraniumUIMaterial() //
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<LocalDbService>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddSingleton<IFileSaver>(FileSaver.Default);

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }

}
