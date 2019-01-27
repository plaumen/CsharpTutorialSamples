using TestManager.Enums;
using TestManager.Interfaces;

namespace TestManager.Tests
{
    public class TestsFactory
    {
        public static ITest Get(TestType testType)
        {
            switch (testType)
            {
                case TestType.DeviceTest:
                    return new DeviceTest();
                case TestType.InstallationTest:
                    return new InstallationTest();
                default:
                    return new DefautTest();
            }
        }
    }
}
