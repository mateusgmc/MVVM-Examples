using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using WPF.Prism.ViewModels;
using WPF.Prism.Views;

namespace WPF.Prism
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow, MainViewModel>();
            containerRegistry.RegisterForNavigation<FooView, FooViewModel>();
            containerRegistry.RegisterForNavigation<BarView, FooViewModel>();
        }
    }
}
