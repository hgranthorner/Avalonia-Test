using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Models;
using MyApp.Services;
using ReactiveUI;

namespace MyApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _content;
        public MainWindowViewModel(IEnumerable<Todo> todos)
        {
            _content = List = new TodoListViewModel(todos);
        }

        public ViewModelBase Content
        {
            get => _content;
            set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public const string Greeting = "Hello World!";
        public TodoListViewModel List { get; }

        public void AddItem()
        {
            Content = new AddItemViewModel();
        }
    }
}
