using System;
using System.Collections.Generic;
using System.Text;
using CsharpSamples.Logger.Enums;

namespace CsharpSamples.Logger
{
    public class Message
    {
        public Message(MessageType type, string text, string context = null)
        {
            Type = type;
            Text = text;
            Context = context;
        }

        public MessageType Type  { get; }

        public string Text { get; }

        public string Context { get; } 
    }
}
