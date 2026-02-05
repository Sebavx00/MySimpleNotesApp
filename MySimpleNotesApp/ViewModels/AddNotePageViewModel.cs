using MySimpleNotesApp.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleNotesApp.ViewModels
{
    public partial class AddNotePageViewModel : ObservableObject
    {
        private Note _note;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private string content;

        public void LoadNote(Note note)
        {
            if (note == null)
                return;

            _note = note;
            Title = note.NoteTitle;
            Content = note.NoteContent;
        }

        [RelayCommand]
        private async Task Save()
        {
            if (_note == null)
            {
                _note = new Note
                {
                    CreatedAt = DateTime.Now
                };
            }

            _note.NoteTitle = Title;
            _note.NoteContent = Content;

            await App.Database.SaveNoteAsync(_note);
            await Shell.Current.GoToAsync("..");
        }
    }
}

