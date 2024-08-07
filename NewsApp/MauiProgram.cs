﻿using Microsoft.Extensions.Logging;

namespace NewsApp
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
                    fonts.AddFont("FontAwesome.otf", "FontAwesome");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
            .RegisterAppTypes();
            return builder.Build();
        }

        public static MauiAppBuilder RegisterAppTypes(this MauiAppBuilder mauiAppBuilder)
        {
            // Services
            mauiAppBuilder.Services.AddSingleton<Services.INewsService>((serviceProvider) => new Services.NewsService());
            mauiAppBuilder.Services.AddSingleton<ViewModels.INavigate>((ServiceProvider) => new Nagivator());
            // ViewModels
            mauiAppBuilder.Services.AddTransient < ViewModels.HeadlinesViewModel>();

            // Views
            mauiAppBuilder.Services.AddTransient<Views.AboutView>();
            mauiAppBuilder.Services.AddTransient<Views.ArticleView>();
            mauiAppBuilder.Services.AddTransient<Views.HeadlinesView>();

            return mauiAppBuilder;
        }
    }
}
