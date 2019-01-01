using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Exceptions
{
    public class ExceptionsSample : ISample
    {
        public void Run()
        {
            TryCatchFinallyScenario();
            ExceptionObjectUsedScenario();
            CatchEverythingScenario();

            // OUTPUT
            // Base exception handled
            // Finally block executed
            // Derived exception Msg
            // I am catching everything!
        }

        private void CatchEverythingScenario()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch
            {
                Console.WriteLine("I am catching everything!");
            }
        }

        private void ExceptionObjectUsedScenario()
        {
            try
            {
                throwDerivedException();
            }
            // you can specify variable name for exception and use it
            catch (DerivedException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void TryCatchFinallyScenario()
        {
            try
            {
                throwBaseException();
                Console.WriteLine("How you came here?");
            }
            catch (BaseException)
            {
                Console.WriteLine("Base exception handled");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }

        private void throwBaseException()
        {
            throw new BaseException();
        }

        private void throwDerivedException()
        {
            throw new DerivedException("Derived exception Msg");
        }
    }

    public class BaseException : Exception
    {
        public BaseException()
        {
        }
    }

    public class DerivedException : BaseException
    {
        public override string Message { get; }

        public DerivedException(string message)
        {
            Message = message;
        }
    }
}
