using CsharpSamples.Logger;
using CsharpSamples.Logger.Enums;
using TestManager.HardwareModels;
using TestManager.Interfaces;

namespace TestManager.Tests
{
    public class DeviceTest : BaseTest, ITest
    {
        private const string _testName = "Device Test";

        private Device _device;

        protected override void Prepare()
        {
            _device = new Device("321-APUD");
            _logger.AddMessage(new Message(MessageType.Info, $"Device with code {_device.DeviceCode} has been created.", _testName));
        }

        protected override void Test()
        {
            _device.Use();

        }

        protected override void Assert()
        {
            if (_device.IsConnected)
            {
                _logger.AddMessage(new Message(MessageType.Info, $"{_device.DeviceCode} has been succesfully connected", _testName));
            }

            if (_device.ErrorsCount > 0)
            {
                _logger.AddMessage(new Message(MessageType.Error, $"{_device.ErrorsCount} errors occured during device {_device.DeviceCode} usage"));
            }
        }
    }
}
