using System;

namespace TestManager.HardwareModels
{
    public class Device
    {
        public Device(string deviceCode)
        {
            DeviceCode = deviceCode;
        }

        public int ErrorsCount { get; private set; }

        public bool IsConnected { get; private set; }

        public string DeviceCode { get; }

        public void Use()
        {
            ErrorsCount = DateTime.Now.Millisecond % 3;

            IsConnected = ErrorsCount == 0;
        }
    }
}
