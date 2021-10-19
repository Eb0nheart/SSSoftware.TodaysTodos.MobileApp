using Xamarin.Forms;

namespace SSSoftware.TodaysTodos.MobileApp.Core.Models
{
    public class Todo : BindableObject
    {
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                var todo = new Todo();
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set 
            { 
                _description = value; 
                OnPropertyChanged(nameof(Description));
            }
        }

    }
}
