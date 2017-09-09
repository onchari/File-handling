using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_handling_using_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            const bool subfoldersSearch = true;
            FileHandling fileHandling = new FileHandling();
            const string path = @"E:\VIdeo Tutorials\AppDev.Learning.to.Program.Using.Visual.C.Sharp.2010(www.vatandownload.com)";

            FileSearch0 fileSearch0 = new FileSearch0(path, subfoldersSearch);



            fileSearch0.FileHandler = fileHandling.DisplayfileName;
            fileSearch0.Execute();



            Console.ReadKey();
        }
    }

    
}
