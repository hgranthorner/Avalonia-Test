using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using MyApp.Models;
using ReactiveUI;

namespace MyApp.ViewModels
{
    class AddItemViewModel : ViewModelBase
    {
        private string _description;


        public AddItemViewModel()
        {
            var okEnabled = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x));


            Ok = ReactiveCommand.Create(
                () => new Todo {Name = Description},
                okEnabled);
            Cancel = ReactiveCommand.Create(() => { });
        }

        public IObservable<bool> OkEnabled { get; set; }

        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }

        public ReactiveCommand<Unit, Todo> Ok { get; }
        public ReactiveCommand<Unit, Unit> Cancel { get; }
    }
}