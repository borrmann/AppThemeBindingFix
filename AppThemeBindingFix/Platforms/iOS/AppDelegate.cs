using AppThemeBindingFix.Services;
using Foundation;
using UIKit;

namespace AppThemeBindingFix
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override void OnActivated(UIApplication application)
        {
            // this is a workaround to prevent the app from crashing when the app is in the background and the window changed
            (application.ConnectedScenes.AnyObject as UIWindowScene)?.Windows.FirstOrDefault()?.MakeKeyWindow();
            base.OnActivated(application);

            DeviceThemeService.Instance.ReloadRequestedTheme();
        }
    }
}
