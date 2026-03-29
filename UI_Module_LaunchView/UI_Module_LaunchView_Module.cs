using UI_Module_LaunchView.Views;

namespace UI_Module_LaunchView
{
    public class UI_Module_LaunchView_Module : IModule
    {
        private readonly IRegionManager regionManager;

        public UI_Module_LaunchView_Module(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegion region = regionManager.Regions["ShellMainRegion"];

            var launchView = containerProvider.Resolve<LaunchView>();
            region.Add(launchView);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
