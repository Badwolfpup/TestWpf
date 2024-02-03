using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TestWpf.Commands;
using TestWpf.Model;
using TestWpf.Views;

namespace TestWpf.ViewModel
{
    public class MainViewModel
    {

        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;
            AddUser addUserWindow = new AddUser();
            addUserWindow.Owner = mainWindow;
            addUserWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWindow.Show();
        }
    }
}
