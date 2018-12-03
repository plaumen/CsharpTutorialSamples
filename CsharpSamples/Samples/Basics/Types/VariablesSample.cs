using CsharpSamples.Common.Interfaces;

namespace CsharpSamples.Samples.Basics.Types
{
    public class VariablesSample : ISample
    {
        public void Run()
        {
            // Solution without variables is unreadable and hard to change
            var delta = (2 * 2 - 4 * 1 * 1) / 2 * 1; // (b^2 - 4*ac) / 2a

            // Solution with badly named variables is unreadable but easy to calculate with various numbers
            int a = 1;
            int h = 1;

            int rectangleArea = a * h;

            // Solution with properly named variables is readable and easy to calculate with various numbers
            int length = 1;
            int height = 2;

            int recangleArea = length * height;
        }
    }
}
