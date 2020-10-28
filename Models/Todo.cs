using System;

namespace MyApp.Models
{
    public class Todo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public bool IsChecked { get; set; }
    }
}