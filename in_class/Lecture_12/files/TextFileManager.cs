namespace ReadingFiles
{
    class TextFileManager
    {
        private string directoryPath;
        private string filePath;

        //constructor to initialize the text file manager with directory and file paths
        public TextFileManager(string directory, string file)
        {
            directoryPath = directory;
            filePath = Path.Combine(directoryPath, file);

            //Create the directory if it doesn't exist. 
            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            //Create the file if it doesn't exist.
            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        //write text from the file
        public void WriteTextToFile(string text)
        {
            using(var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }
        }

        //reads text from the file and returns it   
        public string? ReadTextFromFile()
        {
            using(var reader = new StreamReader(filePath))
            {
                return reader.ReadLine();
            }
        }

    }
}