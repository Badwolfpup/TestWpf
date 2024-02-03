using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpf.Model
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>()
        {
            new User {Name = "Kalle", Email="Kalle@gmail.com"},
            new User {Name = "Anders", Email="Ander@gmail.com"},
            new User {Name = "Sven", Email="Sven@gmail.com"},
            new User {Name = "Lisa", Email="Lisa@gmail.com"},
            new User {Name = "Erik", Email="Erik@gmail.com"},
            new User {Name = "Urban", Email="Urban@gmail.com"},
            new User {Name = "Glen", Email="Glen@gmail.com"},
            new User {Name = "Maria", Email="Maria@gmail.com"},
            new User {Name = "Astrid", Email="Astrid@gmail.com"},
        };

        public static ObservableCollection<User> GetUsers() 
        {
            return _DatabaseUsers;
        }

        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);
        }
    }
}
