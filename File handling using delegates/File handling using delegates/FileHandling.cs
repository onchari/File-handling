using System;
using System.IO;

namespace File_handling_using_delegates
{
    public class FileHandling
    {
        public void DisplayfileName(FileInfo file)
        {
            Console.WriteLine("File Name : {0}", file.Name);
        }

        public void DisplayFileSize(FileInfo file)
        {
            Console.WriteLine("File Size : {0}", file.Length);
        }

        public void DisplayFileExtension(FileInfo file)
        {
            Console.WriteLine("File Extension: {0}", file.Extension);
        }
    }
}