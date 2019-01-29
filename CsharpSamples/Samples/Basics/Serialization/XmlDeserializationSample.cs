using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Serialization.Models;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CsharpSamples.Samples.Basics.Serialization
{
    public class XmlDeserializationSample : ISample
    {
        public void Run()
        {
            var xmlSerializedBlog = @"<?xml version=""1.0""?>
<Blog xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <Name>World blog!</Name>
  <Posts>
    <Post>
      <Author>
        <Name>Patio</Name>
        <Surname>Sutenero</Surname>
      </Author>
      <Text>Lorem ipsum...</Text>
      <Title>About animals</Title>
    </Post>
    <Post>
      <Author>
        <Name>Patio</Name>
        <Surname>Sutenero</Surname>
      </Author>
      <Text>Lorem ipsum...</Text>
      <Title>About plants</Title>
    </Post>
  </Posts>
</Blog>";

            var xmlSerializer = new XmlSerializer(typeof(Blog));
            var memoryStream = new MemoryStream();
            var streamWriter = new StreamWriter(memoryStream);
            streamWriter.Write(xmlSerializedBlog);
            streamWriter.Flush();
            memoryStream.Position = 0;
            var blog = (Blog)xmlSerializer.Deserialize(memoryStream);
            memoryStream.Close();

            System.Console.WriteLine($"Blog name is {blog.Name}" +
                $"\nPosts have titles:\n{string.Join('\n', blog.Posts.Select(p => p.Title))}");

            // OUTPUT
            // Blog name is World blog!
            // Posts have titles:
            // About animals
            // About plants
        }
    }
}
