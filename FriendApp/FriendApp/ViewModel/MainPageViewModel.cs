using FriendApp.Helpers;
using FriendApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FriendApp.ViewModel
{
     public class MainPageViewModel:Notificable
    {
        private FriendRepository friendRepository;
        public ObservableCollection
            <Grouping<string, Friend>> Friends{ get; set; }
        public Command AddFriendCommand{ get; set; }

        private INavigation Navigation;
        public MainPageViewModel()
        {
            friendRepository = new FriendRepository();
            Friends = friendRepository.GetAllGrouped();
        }
        public MainPageViewModel( INavigation navigation)
        {
            Friends = friendRepository.GetAllGrouped();
            
            
        }
        
    }
}
