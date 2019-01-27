using CsharpSamples.Logger;
using CsharpSamples.Logger.Enums;
using System;
using TestManager.Interfaces;

namespace TestManager.Tests
{
    public class InstallationTest : BaseTest, ITest
    {
        protected override void Prepare()
        {
            _logger.AddMessage(new Message(MessageType.Info, $"Start InstallationTest at {DateTime.Now}"));
        }
    }
}
