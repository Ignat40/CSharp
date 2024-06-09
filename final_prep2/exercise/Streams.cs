using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ExamPrep;


/*


    Stream -> ordered sequence of bytes, which is send from one application 
              or input device, to another application or input device. These bytes 
              are written and written and read one after the other and always arrive
              in the same order as they were sent. 
    
            Abstraction for working with data flows. 
            They provide a way to read from and write to 
            different tupe of storage(files, memory, network)

            Stream Classes: Base class for byte streams. Subclasses include:
                            
            Reader and Writer Classes: Higher-level abstractions
                            for reading and writing text and binary data. Examples are:
                            StreamReader: reads bytes from a file and converts them to a file
                            StreamWriter: converts text to bytes and writes them to a file. 
                            BinaryReader:
                            BinaryWriter:

            FileStream: For reading from and writing to files. Supports both 
                        synchronous and asynchronous operations.

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

        Seek method: 

        Flush method: 

        FileSystemWatcher: 

        Named PipeLines & Anonymous PipeLines:

        PipeStream: 

        BufferedStream: 

        Directory Class: 



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