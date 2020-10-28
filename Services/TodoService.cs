using System;
using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Services
{
    public static class TodoService
    {
        public static IEnumerable<Todo> GetToDos()
        {
            return new List<Todo>
            {
                new Todo {Id = Guid.NewGuid(), Name = "Feed Obi", IsChecked = true},
                new Todo {Id = Guid.NewGuid(), Name = "Run dishwasher", IsChecked = false}
            };
        }
    }
}