using FriendApp.Helpers;
using FriendApp.Model;
using FriendApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FriendApp.ViewModel
{
     public class MainPageViewModel:Notificable
    {
        private FriendRepository friendRepository;
        public ObservableCollection
            <Grouping<string, Friend>> Friends{ get; set; }
        public Command AddFriendCommand{ get; set; }
        public Command SearchCommand { get; set; }
        private string filter;
        public string Filter
        {
            get { return filter; }
            set { SetValue(ref filter, value); }
        }
        public Command ItemTappedCommand { get; set; }
        private Friend currentFriend;
        public Friend CurrentFriend
        {
            get { return currentFriend; }
            set { SetValue(ref currentFriend, value); }
        }


        private INavigation Navigation;
        public MainPageViewModel( INavigation navigation)
        {
            friendRepository = new FriendRepository();
            Friends = friendRepository.GetAllGrouped();
            Navigation = navigation;
            AddFriendCommand = new Command(async () => await AddFriend());
            //SearchCommand = new Command(async () => Search());
            ItemTappedCommand = new Command(async () => await NavigationToEditFriendView());
        }

        //public  void Search()
        //{
            
        //}

        public async Task AddFriend()
        {
            await Navigation.PushAsync(new FriendPage());
        }

        public async Task NavigationToEditFriendView()
        {
            await Navigation.PushAsync(new FriendPage(CurrentFriend));
        }
        
    }
}
