#if UWP
namespace AppStudio.Uwp
#else
namespace AppStudio.Xamarin
#endif
{
    public static class LocalSettingNames
    {
        public const string DeviceType = "DEVICETYPE";
        public const string StoreId = "STOREID";

        public const string PhoneValue = "PHONE";
        public const string WindowsValue = "WINDOWS";

        public const string TextViewerFontSize = "TEXTVIEWERFONTSIZE";

        public const string TilesInitialized = "TILESINITIALIZED";
    }
}
