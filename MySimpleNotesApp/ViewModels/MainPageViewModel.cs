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
            {

                Notes.Add(note);
            }
        }


        [RelayCommand]
        public async Task GoToAddNotePage()
        {
            await Shell.Current.GoToAsync(nameof(AddNotePage));
        }

        [RelayCommand]
        private async Task EditNote(Note note)
        {
            await Shell.Current.GoToAsync(
                nameof(AddNotePage),
                new Dictionary<string, object>
                {
                    ["Note"] = note
                });
        }

        [RelayCommand]
        private async Task DeleteNote(Note note)
        {
            if (note == null)
                return;

            bool answer = await Application.Current.MainPage.DisplayAlertAsync("Delete Note","Are you sure you want to delete this note?","Yes","No");

            if (!answer)
                return;

            await App.Database.DeleteNoteAsync(note);
            Notes.Remove(note);
        }



    }
}
