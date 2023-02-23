using Microsoft.Extensions.Logging;
using Recipe.Mobile.Interfaces;
using Recipe.Mobile.Services;
using Recipe.Mobile.ViewModels;
//using Recipe.Mobile.ViewModels;
using Recipe.Mobile.Views;

namespace Recipe.Mobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.RegisterServices()
			.RegisterViewModels()
			.RegisterViews()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<IRecipeService, RecipeService>();

		return mauiAppBuilder;
	}

	public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
	{
        mauiAppBuilder.Services.AddSingleton<RecipesViewModel>();

		return mauiAppBuilder;
	}

	public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<RecipePage>();

        return mauiAppBuilder;
    }
}

