using MySimpleNotesApp.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleNotesApp.ViewModels
{
    [INotifyPropertyChanged]
    public partial class MainPageViewModel
    {
        public List<Note> note = new List<Note>();

        [ObservableProperty]
        string title;

        [ObservableProperty]
        string content;


        [RelayCommand]
        public async Task GoToAddNotePage()
        {
            await Shell.Current.GoToAsync(nameof(AddNotePage));
        }
    }
}
