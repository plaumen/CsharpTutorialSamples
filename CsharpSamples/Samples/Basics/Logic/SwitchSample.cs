using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Logic
{
    public class SwitchSample : ISample
    {
        public void Run()
        {

            var taskStatus = TaskStatus.InProgress;

            var taskAction = getSuggestedActionFor(taskStatus);

            Console.WriteLine($"Suggested action for {taskStatus} is {taskAction}");

            // OUTPUT
            // Suggested action for InProgress is Do it ASAP
        }

        string getSuggestedActionFor(TaskStatus status)
        {
            string action;
            switch (status)
            {
                case TaskStatus.Created:
                    return "Move to ToDo";
                case TaskStatus.ToDo:
                    return "Assign task";
                case TaskStatus.Assigned:
                case TaskStatus.InProgress:
                case TaskStatus.InReview:
                case TaskStatus.InTests:
                    action = "Do it ASAP";
                    break;
                case TaskStatus.Completed:
                    action = "Task completed - do nothing";
                    break;
                default:
                    action = "status task is invalid";
                    break;
            }

            return action;
        }

        enum TaskStatus
        {
            Created = 1,
            ToDo,
            Assigned,
            InProgress,
            InReview,
            InTests,
            Completed
        }
    }
}
