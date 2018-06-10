using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FriendApp.Helpers
{
     public class Grouping<K,T>:ObservableCollection<T>
    {
        public K Key { get; set; }
        public Grouping(K Key,IEnumerable<T> items)
        {
            this.Key = Key;
            foreach (var item in items)
            {
                Items.Add(item);
            }
            
        }

    }
}
