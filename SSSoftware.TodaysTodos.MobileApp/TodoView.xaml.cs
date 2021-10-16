
using SSSoftware.TodaysTodos.MobileApp.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSSoftware.TodaysTodos.MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoView : ContentPage
    {
        public TodoView()
        {
            InitializeComponent();
            BindingContext = new TodoViewModel();
        }
    }
}