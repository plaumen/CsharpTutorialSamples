using System;
using CsharpSamples.Common.Interfaces;

namespace CsharpSamples.Samples.Intermediate.Type
{
    public class IsOperatorSample : ISample
    {
        private class Base
        {
        }

        private class Derived : Base
        {
            public static explicit operator Another(Derived derived) => new Another();
        }

        private class Another
        {
        }

        public void Run()
        {
            // ineheritance
            var baseClassInstance = new Base();
            var derivedClassInstance = new Derived();
            Console.WriteLine($"Is base class of Base type? {(baseClassInstance is Base)}.");

            Console.WriteLine($"Is derived class of Base type? {(derivedClassInstance is Base)}.");
            Console.WriteLine($"Is base class of Derived type? {(baseClassInstance is Derived)}.");

            // variable declaration in if
            if (derivedClassInstance is Base b)
            {
                System.Console.WriteLine($"Yeah! I can use variable b here {b.GetType()}");
            }

            // variable declaration in switch case
            switch (baseClassInstance)
            {
                case Derived derivedType:
                    Console.Write(derivedType);
                    break;
                case Base baseType:
                    System.Console.WriteLine(baseType);
                    break;
                default:
                    break;
            }

            // code below will not work because is operator does not support implicit and explicit conversions
            // if(derivedClassInstance is Another a)
            // {
            // }

            Derived nullDerivedClassObject = null;
            var another = (Another)nullDerivedClassObject;

            if (another != null)
            {
                System.Console.WriteLine("Anoter object exists");
            }

            // OUTPUT:
            // Is base class of Base type? True.
            // Is derived class of Base type? True.
            // Is base class of Derived type? False.
            // Yeah! I can use variable b here CsharpSamples.Samples.Intermediate.Type.IsOperatorSample+Derived
            // CsharpSamples.Samples.Intermediate.Type.IsOperatorSample+Base
            // Anoter object exists

        }
    }
}