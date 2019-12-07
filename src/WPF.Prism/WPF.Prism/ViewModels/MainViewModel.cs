using Prism.Mvvm;
using Prism.Regions;

namespace WPF.Prism.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IRegionManager regionManager) :
            base(regionManager)
        {
        }
    }
}
