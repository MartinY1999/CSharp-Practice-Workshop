using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a file path: ");
            string filePath = Console.ReadLine();
            using (FileStream reader = new FileStream(filePath, FileMode.Open))
            {
                using (FileStream writer = new FileStream("../../../copy.txt", FileMode.Create))
                {
                    byte[] buffer = new byte[128];
                    while (reader.Read(buffer, 0, buffer.Length) != 0)
                    {
                        writer.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
