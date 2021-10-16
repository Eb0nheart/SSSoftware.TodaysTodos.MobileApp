using System.Collections.ObjectModel;
using SSSoftware.TodaysTodos.MobileApp.Core.Models;

namespace SSSoftware.TodaysTodos.MobileApp.Core.ViewModels
{
    public class TodoViewModel 
    {
        public ObservableCollection<Todo> Todos { get; set; }

        public TodoViewModel()
        {
            Todos = new ObservableCollection<Todo>
            {
                new Todo
                {
                    Id = 1,
                    Description = "Clean apartment"
                }
            };
        }
    }
}
