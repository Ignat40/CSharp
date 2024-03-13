using System.Net.Http.Headers;

namespace DemoLibrary
{
    public static class Examples
    {
        public static string ExampleLoadFile(string file)
        {
            if(file.Length < 10)
            {
                throw new ArgumentException("The file name was too short", "file");
                //throw new System.IO.FileNotFoundException();
            }

            return "The file was correctly loaded. ";
        }
    }
}