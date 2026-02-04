using MySimpleNotesApp.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleNotesApp.ViewModels
{
    [INotifyPropertyChanged]
    public partial class AddNotePageViewModel
    {

        [ObservableProperty]
        private string title;
        [ObservableProperty]
        private string content;

        [RelayCommand]
        private async Task Save()
        {
            var note = new Note
            {
                NoteTitle = Title,
                NoteContent = Content,
                CreatedAt = DateTime.Now,
            };

            await App.Database.SaveNoteAsync(note);
            await Shell.Current.GoToAsync("..");
        }
    }
}
