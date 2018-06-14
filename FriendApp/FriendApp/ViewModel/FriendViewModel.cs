using FriendApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FriendApp.ViewModel
{
    public class FriendViewModel
    {
        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public Boolean InEnable { get; set; }
        public Friend FriendModel{ get; set; }
        public Command SaveFriendCommand { get; }
        private INavigation Navigation;

        public FriendViewModel(INavigation navigation)
        {
            FriendModel = new Friend();
            SaveFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public FriendViewModel(INavigation navigation, Friend friend)
        {
            FriendModel = friend;
            SaveFriendCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public async Task SaveFriend()
        {
            await App.DataBase.SaveFriendsAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }
    }
}
