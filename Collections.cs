using System;
using System.IO;
#pragma warning disable 1591
namespace srdoc
{
    public class Exercise29
    {
        public static void Main29()
        {
            FileInfo f = new FileInfo(@".\data\abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
        }

    }
}
