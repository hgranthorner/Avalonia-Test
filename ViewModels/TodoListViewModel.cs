using System.Collections.Generic;
using System.Collections.ObjectModel;
using MyApp.Models;
using MyApp.Services;

namespace MyApp.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<Todo> todos)
        {
            Todos = new ObservableCollection<Todo>(todos);
        }
        
        public ObservableCollection<Todo> Todos { get; }
    }
}