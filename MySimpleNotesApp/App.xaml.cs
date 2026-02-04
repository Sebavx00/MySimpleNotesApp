using Microsoft.Extensions.DependencyInjection;

namespace MySimpleNotesApp
{
    public partial class App : Application
    {
        static NotesDatabase database;

        public static NotesDatabase Database
        {
            get
            {
                if (database == null)
                {
                    var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.db3");

                    database = new NotesDatabase(dbPath);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}