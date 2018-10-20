using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ChatClient.Views;

namespace ChatClient.ViewModels
{
    /// <summary>
    /// Interaction logic for AcceptCancelView.xaml
    /// </summary>
    public partial class AcceptCancelView : Window
    {
        public SettingsViewModel _svm;

        public AcceptCancelView(SettingsViewModel dc)
        {
            InitializeComponent();
            var settingsView = new SettingsView();
            settingsView.DataContext = dc;
            _svm = dc;
            Title = Properties.Resources.Settings;
            MainPanel.Children.Add(settingsView);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
