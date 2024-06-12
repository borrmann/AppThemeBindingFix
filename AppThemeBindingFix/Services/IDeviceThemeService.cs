namespace AppThemeBindingFix
{
    public interface IDeviceThemeService
    {
        /// <summary>
        ///  Get the current theme, light or dark, not unspecified!
        /// </summary>
        AppTheme GetRequestedTheme();

        /// <summary>
        ///  force a reload of the current theme, in case user chose system default, this will trigger an update from platform specific code
        /// </summary>
        void ReloadRequestedTheme();

        /// <summary>
        /// Get the current theme settings, light, dark or unspecified
        /// </summary>
        AppTheme GetThemeSettings();

        /// <summary>
        /// save the current theme settings
        /// </summary>
        /// <param name="theme">light, dark or unspecified</param>
        void SaveThemeSettings(AppTheme theme);
    }
}
