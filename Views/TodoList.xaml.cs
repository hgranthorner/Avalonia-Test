using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyApp.Views
{
    public class TodoListView : UserControl
    {
        public TodoListView()
        {
            InitializeComponent();
        }

        public void SayHello(object sender, RoutedEventArgs routedEventArgs)
        {
            Console.WriteLine("Hello world!");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}