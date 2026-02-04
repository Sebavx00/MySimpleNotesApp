using MySimpleNotesApp.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleNotesApp.ViewModels
{
    [INotifyPropertyChanged]
    public partial class MainPageViewModel
    {
        public ObservableCollection<Note> Notes { get; set; } = new();

        public async Task LoadNotes()
        {
            Notes.Clear();
            var notes = await App.Database.GetNotesAsync();
            foreach (var note in notes)
                Notes.Add(note);
        }


        [RelayCommand]
        public async Task GoToAddNotePage()
        {
            await Shell.Current.GoToAsync(nameof(AddNotePage));
        }
    }
}
