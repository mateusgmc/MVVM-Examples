using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace WPF.MvvmLight.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<FooViewModel>();
            SimpleIoc.Default.Register<BarViewModel>();
        }

        public MainViewModel Main
        {
            get => ServiceLocator.Current.GetInstance<MainViewModel>();
        }

        public FooViewModel Foo
        {
            get => ServiceLocator.Current.GetInstance<FooViewModel>();
        }

        public BarViewModel Bar
        {
            get => ServiceLocator.Current.GetInstance<BarViewModel>();
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}