using AppThemeBindingFix.Services;

namespace AppThemeBindingFix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var sheet = new MySheet();
            await sheet.ShowAsync();
        }

        private void Dark_Clicked(object sender, EventArgs e)
        {
            DeviceThemeService.Instance.SaveThemeSettings(AppTheme.Dark);
            theme.Text = "requested theme: " + DeviceThemeService.Instance.GetRequestedTheme().ToString();
            setting.Text = "theme setting: " + DeviceThemeService.Instance.GetThemeSettings().ToString();
        }

        private void Light_Clicked(object sender, EventArgs e)
        {
            DeviceThemeService.Instance.SaveThemeSettings(AppTheme.Light);
            theme.Text = "requested theme: " + DeviceThemeService.Instance.GetRequestedTheme().ToString();
            setting.Text = "theme setting: " + DeviceThemeService.Instance.GetThemeSettings().ToString();
        }

        private void System_Clicked(object sender, EventArgs e)
        {
            DeviceThemeService.Instance.SaveThemeSettings(AppTheme.Unspecified);
            theme.Text = "requested theme: " + DeviceThemeService.Instance.GetRequestedTheme().ToString();
            setting.Text = "theme setting: " + DeviceThemeService.Instance.GetThemeSettings().ToString();
        }
    }

}
