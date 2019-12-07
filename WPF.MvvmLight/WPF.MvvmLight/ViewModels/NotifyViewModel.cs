using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace WPF.MvvmLight.ViewModels
{
    public abstract class NotifyViewModel : ViewModelBase
    {
        public NotifyViewModel()
        {
            NavigateCommand = new RelayCommand<string>(NavigateExecute);
        }

        public RelayCommand<string> NavigateCommand { get; }

        private void NavigateExecute(string uri)
        {
            Messenger.Default.Send<string>(uri);
        }
    }
}
