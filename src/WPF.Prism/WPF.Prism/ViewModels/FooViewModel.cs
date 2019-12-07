using Prism.Regions;

namespace WPF.Prism.ViewModels
{
    public class FooViewModel : ViewModelBase
    {
        public FooViewModel(IRegionManager regionManager) :
            base(regionManager)
        {
        }
    }
}
