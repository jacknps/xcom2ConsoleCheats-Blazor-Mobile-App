using System;
using Microsoft.MobileBlazorBindings;
using Microsoft.Extensions.Hosting;
using Xamarin.Essentials;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;
using xcom2ConsoleCheats.ViewModels;

namespace xcom2ConsoleCheats
{
    public class App : Application
    {
        public App()
        {
            var host = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Register app-specific services
                    //services.AddSingleton<AppState>();
                    services.AddSingleton<ListCheatsViewModel>();
                })
                .Build();

            var mdp = new MasterDetailPage
            {
                Master = new ContentPage
                {
                    Title = "XCOM 2 Console Cheats"
                },
                Detail = new ContentPage(),
                MasterBehavior = MasterBehavior.Popover
        };
            MainPage = mdp;

            host.AddComponent<HelloWorld>(parent: mdp.Detail);
            host.AddComponent<ListCheatSections>(parent: mdp.Master);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
