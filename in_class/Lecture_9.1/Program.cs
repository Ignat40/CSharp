using System;
using System.Drawing;
using SkiaSharp;

class Program
{
    static void Main(string[] args)
    {
        SKBitmap bitmap = SKBitmap.Decode("/Users/ignat/Desktop/ex2c.PNG");

        if (bitmap == null)
        {
            Console.WriteLine("Failed to load the image.");
        }
        else
        {
            // Resize the image for better ASCII representation
            int targetWidth = 80; // Set your desired width
            int targetHeight = (int)(bitmap.Height * (float)targetWidth / bitmap.Width);
            SKBitmap resizedBitmap = bitmap.Resize(new SKImageInfo(targetWidth, targetHeight), SKFilterQuality.High);

            // Convert the image to ASCII characters
            string asciiArt = ConvertToAscii(resizedBitmap);

            // Print the ASCII art to the console
            Console.WriteLine(asciiArt);
        }
    }

    static string ConvertToAscii(SKBitmap bitmap)
    {
        char[] asciiChars = { ' ', '.', ':', '-', '=', '+', '*', '#', '%', '8', '@' };
        string asciiArt = "";

        for (int y = 0; y < bitmap.Height; y++)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                // Get the grayscale intensity of the pixel
                SKColor pixelColor = bitmap.GetPixel(x, y);
                int intensity = (int)(0.299 * pixelColor.Red + 0.587 * pixelColor.Green + 0.114 * pixelColor.Blue);

                // Map grayscale intensity to ASCII characters
                int index = intensity * (asciiChars.Length - 1) / 255;
                char asciiChar = asciiChars[index];

                // Append the ASCII character to the ASCII art
                asciiArt += asciiChar;
            }
            asciiArt += "\n"; // Newline after each row
        }

        return asciiArt;
    }
}
