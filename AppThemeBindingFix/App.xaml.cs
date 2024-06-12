
using AppThemeBindingFix.Services;

namespace AppThemeBindingFix
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            DeviceThemeService.Instance.ReloadRequestedTheme();

            Current.RequestedThemeChanged += (sender, args) => {
                DeviceThemeService.Instance.ReloadRequestedTheme();
            };
        }
    }
}
