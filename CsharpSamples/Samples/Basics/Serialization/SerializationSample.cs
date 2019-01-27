using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Serialization.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CsharpSamples.Samples.Basics.Serialization
{
    public class SerializationSample : ISample
    {
        public void Run()
        {
            var author = new Author { Name = "Patio", Surname = "Sutenero" };
            var postAboutAnimals = new Post { Title = "About animals", Content = "Lorem ipsum...", Author = author };
            var postAboutPlants = new Post { Title = "About plants", Content = "Lorem ipsum...", Author = author };
            var blog = new Blog { Name = "World blog!", Posts = new List<Post> { postAboutAnimals, postAboutPlants } };

            var xmlSerializer = new XmlSerializer(typeof(Blog));

            var memoryStream = new MemoryStream();

            xmlSerializer.Serialize(memoryStream, blog);
            memoryStream.Position = 0;
            var streamReader = new StreamReader(memoryStream);
            var serializedXmlContent = streamReader.ReadToEnd();

            System.Console.WriteLine(serializedXmlContent);
            memoryStream.Close();

            // OUTPUT
            // <?xml version="1.0"?>
            // <Blog xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            //   <Name>World blog!</Name>
            //   <Posts>
            //     <Post>
            //       <Author>
            //         <Name>Patio</Name>
            //         <Surname>Sutenero</Surname>
            //       </Author>
            //       <Text>Lorem ipsum...</Text>
            //       <Title>About animals</Title>
            //     </Post>
            //     <Post>
            //       <Author>
            //         <Name>Patio</Name>
            //         <Surname>Sutenero</Surname>
            //       </Author>
            //       <Text>Lorem ipsum...</Text>
            //       <Title>About plants</Title>
            //     </Post>
            //   </Posts>
            // </Blog>
        }
    }
}

