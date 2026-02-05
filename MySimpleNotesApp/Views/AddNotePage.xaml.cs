namespace MySimpleNotesApp.Views;

[QueryProperty(nameof(Note), "Note")]
public partial class AddNotePage : ContentPage
{
    public Note Note
    {
        set => ((AddNotePageViewModel)BindingContext).LoadNote(value);
    }
    public AddNotePage()
	{
		InitializeComponent();
        BindingContext = new AddNotePageViewModel();
    }
}