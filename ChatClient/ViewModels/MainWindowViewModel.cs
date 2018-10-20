using ChatClient.Pages;
using ChatClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChatClient.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            _currentPage = new WelcomePage();
            SettingsCommand = new CommandHandler(() =>
            {
                var dc = new SettingsViewModel();
                if ((bool)new AcceptCancelView(dc).ShowDialog())
                {
                    Properties.Settings.Default.Settings_Test = dc.Test;
                    Properties.Settings.Default.Settings_Test1 = dc.Test1;
                    Properties.Settings.Default.Settings_SliderVal = dc.SliderVal;
                    Properties.Settings.Default.Settings_TextVal = dc.TextVal;
                    Properties.Settings.Default.Save();
                }
            });

            AboutCommand = new CommandHandler(() =>
            {
                var about = new AboutView().ShowDialog();
            });
        }

        public ICommand SettingsCommand { get; set; }
        public ICommand AboutCommand { get; set; }

        private Page _currentPage;
        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }
    }
}
