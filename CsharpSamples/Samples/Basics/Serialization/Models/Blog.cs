using System.Collections.Generic;

namespace CsharpSamples.Samples.Basics.Serialization.Models
{
    public class Blog
    {
        public string Name { get; set; }

        public List<Post> Posts { get; set; }
    }
}
