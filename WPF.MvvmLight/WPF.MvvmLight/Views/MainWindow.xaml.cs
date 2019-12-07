using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace WPF.MvvmLight.Views
{
    /// <summary>
    /// Lógica interna para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<string>(this, LoadWindow);
        }

        private void LoadWindow(string uri)
        {
            if(uri == "FooView")
            {
                Container.Content = new FooView();
            }
            else if(uri == "BarView")
            {
                Container.Content = new BarView();
            }
        }
    }
}
