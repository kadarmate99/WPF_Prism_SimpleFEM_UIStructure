using System.Windows;
using UI_Module_LaunchView;
using UI_Module_Workspace;
using UI_Shell.Views;

namespace UI_Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<UI_Module_LaunchView_Module>();
            moduleCatalog.AddModule<UI_Module_Workspace_Module>();
        }
    }

}
