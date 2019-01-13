using CsharpSamples.Common.Interfaces;
using System;
using System.Collections.Generic;

namespace CsharpSamples.Samples.Basics.Collections
{
    public class QueueSample : ISample
    {
        public void Run()
        {
            var patientsQueue = new Queue<Patient>();
            var startDate = DateTime.Now;
            for (int patientIndex = 1; patientIndex <= 6; patientIndex++)
            {
                patientsQueue.Enqueue(new Patient(patientIndex, startDate.AddHours(patientIndex)));
            }

            Console.WriteLine("Doctor came to office and will start healing patients.");
            while (patientsQueue.Count > 0)
            {
                var patientToHeal = patientsQueue.Dequeue();
                Console.WriteLine($"{patientToHeal} is healed by a doctor.");
            }

            // OUTPUT
            // Doctor came to office and will start healing patients.
            // Patient 1 registered at 17:13:16 is healed by a doctor.
            // Patient 2 registered at 18:13:16 is healed by a doctor.
            // Patient 3 registered at 19:13:16 is healed by a doctor.
            // Patient 4 registered at 20:13:16 is healed by a doctor.
            // Patient 5 registered at 21:13:16 is healed by a doctor.
            // Patient 6 registered at 22:13:16 is healed by a doctor.
        }
    }

    public class Patient
    {
        private int _number;

        private DateTime _registrationDateTime;

        public Patient(int number, DateTime registrationTime)
        {
            _number = number;
            _registrationDateTime = registrationTime;
        }

        public override string ToString()
        {
            return $"Patient {_number} registered at {_registrationDateTime:HH:mm:ss}";
        }
    }
}
