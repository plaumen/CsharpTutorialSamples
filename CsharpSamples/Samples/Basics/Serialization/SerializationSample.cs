using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Serialization.Models;
using Newtonsoft.Json;
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

            var jsonSerializedBlog = JsonConvert.SerializeObject(blog);

            System.Console.WriteLine(jsonSerializedBlog);

            // OUTPUT XML
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

            // OUTPUT JSON
            // {
            //    "Name": "World blog!",
            //    "Posts": [
            //        {
            //            "CreationDateTime": "2019-01-29T17:58:27.9124154+01:00",
            //            "Author": {
            //                "Name": "Patio",
            //                "Surname": "Sutenero"
            //            },
            //            "Content": "Lorem ipsum...",
            //            "Title": "About animals"
            //        },
            //        {
            //            "CreationDateTime": "2019-01-29T17:58:27.9153015+01:00",
            //            "Author": {
            //                "Name": "Patio",
            //                "Surname": "Sutenero"
            //            },
            //            "Content": "Lorem ipsum...",
            //            "Title": "About plants"
            //        }
            //    ]
            //}
        }
    }
}

