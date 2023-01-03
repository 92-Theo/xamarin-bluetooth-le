using Android.Bluetooth;

namespace Plugin.BLE.Android.Extensions
{
    public static class GattStatusExtension
    {
        /*
        * 22.12.29,CTY
        * Refresh Cache code 추가
        * stats == 133 OR 257
        * 133 : gatt error
        * 257 : unknwon, to many connect ???
        */
        public static bool IsRefreshCache(this GattStatus status)
        {
            var val = (int)status;
            return val == 133 || val == 257;
        }
    }
}
