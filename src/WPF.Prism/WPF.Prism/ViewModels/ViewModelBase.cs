using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace WPF.Prism.ViewModels
{
    public abstract class ViewModelBase : BindableBase
    {
        protected readonly IRegionManager RegionManager;

        public ViewModelBase(IRegionManager regionManager)
        {
            RegionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(NavigateExecute);
        }

        public DelegateCommand<string> NavigateCommand { get; }

        protected virtual void NavigateExecute(string uri)
        {
            if (!string.IsNullOrEmpty(uri))
            {
                RegionManager.RequestNavigate("ContentRegion", uri);
            }
        }
    }
}
