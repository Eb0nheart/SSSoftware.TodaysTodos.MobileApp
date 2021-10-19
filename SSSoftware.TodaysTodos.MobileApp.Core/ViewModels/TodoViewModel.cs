using System.Collections.ObjectModel;
using SSSoftware.TodaysTodos.MobileApp.Core.Models;

namespace SSSoftware.TodaysTodos.MobileApp.Core.ViewModels
{
    public class TodoViewModel : BaseViewModel
    {
        private const string GetUrl = "http://192.168.87.132:3000/todo";
        private readonly HttpClient httpClient;

        public ObservableCollection<Todo> Todos { get; set; }

        public TodoViewModel(HttpClient httpClient)
        {
            Todos = new ObservableCollection<Todo>();
            this.httpClient = httpClient;
        }

        public override async Task InitializeAsync()
        {
            try
            {
                var todos = await httpClient.GetFromJsonAsync<IEnumerable<Todo>>(GetUrl);
                foreach (var todo in todos)
                {
                    Todos.Add(todo);
                }
            }
            catch (HttpRequestException)
            {
                // TODO: Configure logging and log error here.
            }
            catch
            {
                throw;
            }
        }
    } 
}
