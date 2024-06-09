using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ExamPrep;


/*


    Stream -> ordered sequence of bytes, which is send from one application 
              or input device, to another application or output device. These bytes 
              are written and read one after the other and always arrive
              in the same order as they were sent. 
    
            Abstraction for working with data flows. 
            They provide a way to read from and write to 
            different tupe of storage(files, memory, network)

            Stream Class: Base class for byte streams.
                Methods:
                    - Read() -> reads sequence of bytes 
                    - Write() -> writes a sequence of bytes 
                    - Seek() -> Sets the Position within the current stream
                    - SetLength() -> Sets the length of the current stream
                    - Flush() -> Clears all buffers for this stream and casues any buffered data to be written to the underlying device. 
            
            Subclasses include:
                            
            Reader and Writer Classes: Higher-level abstractions
                            for reading and writing text and binary data. Examples are:
                            StreamReader: reads bytes from a file and converts them to a file
                            StreamWriter: converts text to bytes and writes them to a file. 
                            BinaryReader:
                            BinaryWriter:

            FileStream: For reading from and writing to files. Supports both 
                        synchronous and asynchronous operations.

            MemoryStream: Uses memory as the backing store, useful for temporary storage. 

            BufferedStream: Adds a buffering layer to another stream to improve read and write perfomrmance 

            NetworkStream: Used for network operations

            StreamReader & StreamWriter: For handling text files. Provide
            methods for reading and writing text data efficiently. 

        ! Two Types of Streams ! 

            Text Streams:
                • Can only work with text data ot a sequence of characters. 
                  
                • TextReader & TextWriter: abstractd class and cannot be instantiated
                    - ReadLine() - reads one line of text and returns a string
                    - ReadToEnd() - reads the entire stream to its end and returns a string.
                    - Write() - writes a string to the stream
                    - WriteLine() - writes one line of text into the stream 
                

            Binary Streams: 
                • Work with binary(raw) data. Makes them universal and they can
                  read information from all sorts of files(images, music and multimedia, text, etc.)

                • FileStream -> provides various methods for reading and 
                                writing from a binary file. 
                  BinaryWriter -> enables you to write primitive types 
                                  binary values in a specific encoding to a stream. 
                                  It has one main method - Write() 
                  BinaryReader -> allows you to read primitive data types and binary
                                  values in a specific encoding stream. 
                  NetworkStream: 

        

        FileSystemWatcher: Used to monitor changes in a specified directory or file.
                           It can detect chagnes such as the creation, deletion, modificadtion, renaming of files and dicrectories.

                           Path - specifies the dir to monitor
                           Filter - defines the types of files to watch (e.g, .txt)

                            Changed: Triggered when a file or directory in the specified path is modified.
                            Created: Triggered when a new file or directory is created.
                            Deleted: Triggered when a file or directory is deleted.
                            Renamed: Triggered when a file or directory is renamed.


        Named PipeLines & Anonymous PipeLines:
        
            Named pipes are a mechanism for inter-process communication (IPC)
            that can be used for communication between processes on the same machine or across a network.

            Server-Client Model: One process creates a named pipe (server), and another connects to it (client).
            Persistent: Named pipes are persistent and can be accessed using a unique name.


            Anonymous pipes are simpler than named pipes and are used for communication between a parent and child process.

            Parent-Child Communication: Typically used for communication between a parent process and its child process.
            In-Memory: Anonymous pipes do not have a name and are managed in memory.

            PipeStream -> the base class for named and anonymous pipes in .NET.

        BufferedStream: is a wrapper around another stream that provides a buffer to reduce the number of I/O operations. 
                        This improves performance for frequent small reads and writes.

        Directory Class: provides static methods for creating, moving, and enumerating through directories and subdirectories.



*/

public class FileStream
{
    public static void ReverseFileStream()
    {
        string inputFilePath = "/Users/ignat/Desktop/CSharp/final_prep2/exercise/files/file1.txt";
        string outputFilePath = "/Users/ignat/Desktop/CSharp/final_prep2/exercise/files/reversed.txt";

        //Read
        string content = File.ReadAllText(inputFilePath);

        //Reverse the content 
        char[] reversedContent = content.ToCharArray();
        Array.Reverse(reversedContent);

        //Write 
        File.WriteAllText(outputFilePath, new string(reversedContent));


    }


}

class MemoryStreamClass
{
    public static void MemoryStreamRead()
    {

        string inputFilePath = "/Users/ignat/Desktop/CSharp/final_prep2/exercise/files/test.drawio.png";
        string outputFilePath = "/Users/ignat/Desktop/CSharp/final_prep2/exercise/files/test.png";

        // using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(inputFilePath)))
        // {
        //     using (Image image = Image.FromStream(memoryStream))
        //     {
        //         Bitmap bitmap = new Bitmap(image);

        //         for (int y = 0; y < bitmap.Height; y++)
        //         {
        //             for (int x = 0; x < bitmap.Width; x++)
        //             {
        //                 Color originalColor = bitmap.GetPixel(x, y);
        //                 int grayValue = (int)(originalColor.R * 0.299 + originalColor.G * 0.587 + originalColor.B * 0.114);
        //                 Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
        //                 bitmap.SetPixel(x, y, grayColor);
        //             }
        //         }

        //         bitmap.Save(outputFilePath, ImageFormat.Jpeg);
        //     }
        //}
    }
}