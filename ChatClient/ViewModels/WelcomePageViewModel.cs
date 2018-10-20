using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ChatClient.Views;

namespace ChatClient.ViewModels
{
    public class WelcomePageViewModel : ViewModelBase
    {
        public WelcomePageViewModel()
        {
           EnterCommand = new CommandHandler(() =>
           {
               MessageBox.Show("ffff");
           }, !string.IsNullOrEmpty(Login));
        }

        public ICommand EnterCommand { protected set; get; }

        private string _login;
        public string Login {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }
    }
}
