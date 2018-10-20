using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ChatClient.Views;

namespace ChatClient.ViewModels
{
    public class AcceptCancelViewModel : ViewModelBase
    {
        public AcceptCancelViewModel()
        {
            AcceptCommand = new CommandHandler(() =>
            {

            });
        }

        public ICommand AcceptCommand;
    }
}
