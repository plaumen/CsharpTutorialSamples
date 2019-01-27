using System;
using System.Collections.Generic;
using System.Text;
using CsharpSamples.Logger.Enums;

namespace CsharpSamples.Logger.Interfaces
{
    public interface ILogger
    {
        void AddMessage(Message message);
        void PrintMessages();

        List<Message> Messages { get; }
    }
}
