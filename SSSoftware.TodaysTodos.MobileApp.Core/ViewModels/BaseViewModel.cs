using System.Windows.Input;
using Xamarin.Forms;

namespace SSSoftware.TodaysTodos.MobileApp.Core.ViewModels
{
    public abstract class BaseViewModel
    {
        public abstract Task InitializeAsync();

        public ICommand LoadDataCommand
            => new Command(() => InitializeAsync());
    }
}
