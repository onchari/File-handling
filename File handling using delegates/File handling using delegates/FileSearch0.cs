using System;
using System.Collections.Generic;
using System.IO;


namespace File_handling_using_delegates
{
    public delegate void FileHandlerDelegate(FileInfo file);
    public class FileSearch0
    {
        public bool SearchSubfolders;

        public FileSearch0(string path, bool searchSubfolders)
        {
            LookIn = path;
            SearchSubfolders = searchSubfolders;
        }

        public string LookIn { get; }
        public FileHandlerDelegate FileHandler { get; set; } = null;
        protected List<FileInfo> Files { get; } = new List<FileInfo>();

        public List<FileInfo> Execute()
        {
            Search(LookIn);
            return Files;
        }

        internal virtual void Search(string path)
        {
            var localDirectoryInfo = new DirectoryInfo(path);
            try
            {
                if (SearchSubfolders)
                    foreach (var directory in localDirectoryInfo.GetDirectories())
                        Search(directory.FullName);
                var localFiles = localDirectoryInfo.GetFiles();
                foreach (var fileInfo in localFiles)
                    if (FileHandler != null)
                        FileHandler.Invoke(fileInfo);

                Files.AddRange(localFiles);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}