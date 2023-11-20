namespace ReadingFiles
{
    class Program
    {
        /*
       1.Discover the file and the directory classes.
       2. Understand how .NET uses streams to access files.
       3. Writing and reading from file.

       Probelm: Text file manger.
       Obejective: Develop a console application that allows the user to:
       1. Create a durectory and a text file within that directory
       2. Write user umput to the text file
       3. Read and display the contents
       */
        public static void Main()
        {
            string directoryToMontor = Directory.GetCurrentDirectory();
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory());

            DirectoryMonitor monitor = new(directoryToMontor, logFilePath);
            Console.WriteLine("Monitoring directory. Press 'c' to compress log, 'd' to decompress of 'e' to exit");

            while(true)
            {
                var key = Console.ReadKey(true).Key;
                if(key == ConsoleKey.C)
                {
                    string compressedFilePath = Path.Combine(Directory.GetCurrentDirectory(), "compressfile_log.gz");
                    monitor.CompressLogFile(compressedFilePath);
                    Console.WriteLine("File compressed");
                }
                else if(key == ConsoleKey.D)
                {
                    string decompressedFileStream = Path.Combine(Directory.CreateDirectory(), "decompressed_log.txt");
                    string inputFilePath = Path.Combine(Directory.GetCurrentDirectory(), "compressed_log.gz");
                    monitor.DecompressLogFile(decompressedFileStream);
                }
                else if(key == ConsoleKey.E)
                {
                    break;
                }
            }
        }

        public void ReadingWritingFile()
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "TextFileManagerDir");
            string file = Path.Combine(directoryPath, "text.txt");

            var fileManager = new TextFileManager(directoryPath, file);
            try
            {
                Console.WriteLine("Enter text to write in the file: ");
                string? userInput = Console.ReadLine();
                while (userInput == null)
                {
                    userInput = Console.ReadLine();
                }

                fileManager.WriteTextToFile(userInput);

                string? fileContents = fileManager.ReadTextFromFile();
                if (fileContents != null)
                {
                    Console.WriteLine("\nContents of the file: ");
                    Console.WriteLine(fileContents);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error accured: {ex.Message}");
            }
        }

        public void ReadWriteNoteApp()
        {
            //Define the directory for storing notes.
            string notesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "NoteManagerDir");

            //create an instance of the class
            var noteManager = new NoteManager(notesDirectory);

            //User ui for note taking
            Console.WriteLine("Simple note-taking system");
            Console.WriteLine("1. Write Note");
            Console.WriteLine("2. Read a Note");
            Console.Write("Select an opiton: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter note name: ");
                    string? noteNameWrite = Console.ReadLine();
                    Console.WriteLine("Enter note content (end with a blank line).");
                    string noteContent = "";
                    string? line;
                    while ((line = Console.ReadLine()) != "")
                    {
                        noteContent += line + Environment.NewLine;
                    }

                    noteManager.WriteNote(noteNameWrite, noteContent);
                    break;
                case "2":
                    Console.WriteLine("Enter note name: ");
                    string? noteNameRead = Console.ReadLine();
                    string content = noteManager.ReadNote(noteNameRead);
                    if (content != null)
                    {
                        Console.WriteLine("Note Content");
                        Console.WriteLine(content);
                    }
                    break;
                default:
                    break;
            }


            /*
            
            */
        }

        // public static long[] Digitize(long n)
        // {
        //     // Code goes here
        // }

    }
}