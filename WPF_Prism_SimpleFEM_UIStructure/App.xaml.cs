using System.Windows;
using WPF_Prism_SimpleFEM_UIStructure.Views;

namespace WPF_Prism_SimpleFEM_UIStructure
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
    }

}
