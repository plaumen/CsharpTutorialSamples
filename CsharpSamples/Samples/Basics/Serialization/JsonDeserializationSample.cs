using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Serialization.Models;
using Newtonsoft.Json;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Serialization
{
    public class JsonDeserializationSample : ISample
    {
        public void Run()
        {
            var jsonSerializedBlog = @"{
    ""Name"": ""World blog!"",
    ""Posts"": [
        {
            ""CreationDateTime"": ""2019-01-29T17:58:27.9124154+01:00"",
            ""Author"": {
                ""Name"": ""Patio"",
                ""Surname"": ""Sutenero""
            },
            ""Content"": ""Lorem ipsum..."",
            ""Title"": ""About animals""
        },
        {
            ""CreationDateTime"": ""2019-01-29T17:58:27.9153015+01:00"",
            ""Author"": {
                ""Name"": ""Patio"",
                ""Surname"": ""Sutenero""
            },
            ""Content"": ""Lorem ipsum..."",
            ""Title"": ""About plants""
        }
    ]
}";

            var blog = JsonConvert.DeserializeObject<Blog>(jsonSerializedBlog);

            System.Console.WriteLine($"Blog name is {blog.Name}" +
              $"\nPosts have titles:\n{string.Join("\n", blog.Posts.Select(p => p.Title))}");

            // OUTPUT
            // Blog name is World blog!
            // Posts have titles:
            // About animals
            // About plants
        }
    }
}
