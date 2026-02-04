namespace MySimpleNotesApp
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm = new();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.LoadNotes();
        }
        
    }
}
