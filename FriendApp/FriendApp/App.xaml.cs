

namespace FriendApp
{
    using FriendApp.Data;
    using FriendApp.Services;
    using Xamarin.Forms;
    public partial class App : Application
	{
        private static FriendDataBase database;    

        public static FriendDataBase DataBase
        {
            get
            {
                if (database == null)
                {
                    database = new FriendDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsbd.db3"));
                   
                }
                return database;
            }

        }
        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage (new View.MainPage ());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
