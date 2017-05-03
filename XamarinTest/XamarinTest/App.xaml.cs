using Xamarin.Forms;
using XamarinTest.Database;

namespace XamarinTest
{
    public partial class App : Application
    {
        static XamarinTestDatabase database;
        public App()
        {
            InitializeComponent();

            Xamarin.Forms.DataGrid.DataGridComponent.Init();

            MainPage = new XamarinTest.MainPage();                        
        }

        public static XamarinTestDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new XamarinTestDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("XamarinTestSQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
