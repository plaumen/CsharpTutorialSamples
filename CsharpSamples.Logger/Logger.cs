using CsharpSamples.Logger.Interfaces;
using System;
using System.Collections.Generic;

namespace CsharpSamples.Logger
{
    public class Logger : ILogger
    {
        private List<Message> _messages = new List<Message>();

        public void AddMessage(Message message)
        {
            _messages.Add(message);
        }

        public void PrintMessages()
        {
            foreach (var message in _messages)
            {
                Console.WriteLine($"{message.Type} {message.Text} {message.Context}".Trim());
            }
        }

        public List<Message> Messages => _messages;
    }
}
