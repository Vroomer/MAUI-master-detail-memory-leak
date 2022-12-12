using Microsoft.Extensions.Logging;

namespace MauiApp14;

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

		builder.Services.AddTransient(typeof(DetailPage));
		builder.Services.AddTransient(typeof(DetailPageViewModel));
		builder.Services.AddTransient(typeof(MainPage));
		builder.Services.AddTransient(typeof(MainPageViewModel));

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
