using System;
using System.IO;

namespace AsciiArt
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using (var image = Properties.Resources.Receipt2)
            {
                var text = ImageConverter.ConvertImage(image);
                

                //Console.Write(text);

                System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteLines.txt", text);
            }

            //Console.ReadKey();
        }
    }
}