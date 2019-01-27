using System;
using System.Xml.Serialization;

namespace CsharpSamples.Samples.Basics.Serialization.Models
{
    public class Post
    {
        public DateTime CreationDateTime { get; } = DateTime.Now;

        public Author Author { get; set; }

        [XmlElement("Text")]
        public string Content { get; set; }

        public string Title { get; set; }
    }
}
