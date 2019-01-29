using CsharpSamples.Common.Interfaces;
using System.IO;

namespace CsharpSamples.Samples.Basics.Files
{
    public class FileSample : ISample
    {
        public void Run()
        {
            var filename = "jestem-gucio.txt";
            var content = "Obst und Gemuse";

            WriteToFile(filename, content);

            var readContent = ReadFile(filename);

            if (readContent == content)
            {
                System.Console.WriteLine("Read content is OK");
            }
            else
            {
                System.Console.WriteLine($"Read content is not OK.");
            }

            File.Delete(filename);

            System.Console.WriteLine(File.Exists(filename) ? $"File {filename} exists." : $"File {filename} was remove successfully.");

            // OUTPUT
            // Read content is OK
            // File jestem - gucio.txt was remove successfully.
        }

        private void WriteToFile(string filename, string content)
        {
            using (var filestream = File.Create(filename))
            {

                var streamWriter = new StreamWriter(filestream);
                streamWriter.Write(content);
                streamWriter.Close();
            }
        }

        private string ReadFile(string filename)
        {
            var readContent = string.Empty;
            using (var filestream = File.OpenRead(filename))
            {
                var streamReader = new StreamReader(filestream);
                readContent = streamReader.ReadToEnd();
                streamReader.Close();
            }

            return readContent;
        }
    }
}
