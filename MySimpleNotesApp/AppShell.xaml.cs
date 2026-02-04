using MySimpleNotesApp.Views;

namespace MySimpleNotesApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddNotePage),typeof(AddNotePage));
        }
    }
}
