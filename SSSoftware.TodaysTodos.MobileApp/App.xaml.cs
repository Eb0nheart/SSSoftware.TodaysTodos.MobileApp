using Microsoft.Extensions.DependencyInjection;
using SSSoftware.TodaysTodos.MobileApp.Core.ViewModels;
using System;
using System.Net.Http;
using Xamarin.Forms;

namespace SSSoftware.TodaysTodos.MobileApp
{
    public partial class App : Application
    {
        protected static IServiceProvider ServiceProvider;

        public App()
        {
            InitializeComponent();
            
            SetupServices();

            MainPage = new TodoView();
        }

        public static TViewModel GetViewModel<TViewModel>() where TViewModel : class 
            => ServiceProvider.GetService<TViewModel>();

        protected override void OnStart()
        {
            SetupServices();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void SetupServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton(_ => new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (_,_,_,_) => true
            })) ;

            services.AddTransient<TodoViewModel>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
