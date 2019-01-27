using CsharpSamples.Logger;
using CsharpSamples.Logger.Enums;
using CsharpSamples.Logger.Interfaces;
using System;
using TestManager.Enums;
using TestManager.Interfaces;

namespace TestManager.Tests
{
    public abstract class BaseTest : ITest
    {
        protected ILogger _logger = new Logger();

        public TestResult Run()
        {
            _logger.AddMessage(new Message(MessageType.Info, $"Start test execution at {DateTime.Now:g}"));

            Prepare();
            Test();
            Assert();

            _logger.PrintMessages();

            return TestResult.Passed;
        }

        protected virtual void Prepare()
        {
            _logger.AddMessage(new Message(MessageType.Info, "Prepare from BaseTest"));
        }

        protected virtual void Test()
        {
            _logger.AddMessage(new Message(MessageType.Info, "Test from BaseTest"));
        }

        protected virtual void Assert()
        {
            _logger.AddMessage(new Message(MessageType.Info, "Assert from BaseTest"));
        }
    }
}
