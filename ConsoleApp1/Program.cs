using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Directory.GetFiles("temp");
Console.WriteLine(GetMagicNumbers("temp/4.txt", 4));
var f = File.ReadAllBytes("temp/4.txt");
ASCIIEncoding ascii = new ASCIIEncoding();
// Create an ASCII byte array.
Byte[] bytes = ascii.GetBytes(f.ToString()); 
        
// Display encoded bytes.
Console.Write("Encoded bytes (in hex):  ");
foreach (var value in bytes)
    Console.Write("{0:X2} ", value);
Console.WriteLine();

// Decode the bytes and display the resulting Unicode string.
String decoded = ascii.GetString(bytes);
Console.WriteLine("Decoded string: '{0}'", decoded);


//txt 64636268

           // Assert.AreEqual("25504446", GetMagicNumbers(filePath, 4));
//           filename = "file.mp3",
//           hexSignature = "494433",

//            filename = "file.png",
//            hexSignature = "89504E470D0A1A0A",
        }
        private static string GetMagicNumbers(string filepath, int bytesCount)
        {
            // https://en.wikipedia.org/wiki/List_of_file_signatures

            byte[] buffer;
            using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
                buffer = reader.ReadBytes(bytesCount);

            var hex = BitConverter.ToString(buffer);
            return hex.Replace("-", String.Empty).ToLower();

        }
    }
}