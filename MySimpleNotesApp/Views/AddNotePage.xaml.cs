namespace MySimpleNotesApp.Views;

public partial class AddNotePage : ContentPage
{
	public AddNotePage()
	{
		InitializeComponent();
        BindingContext = new AddNotePageViewModel();
    }
}