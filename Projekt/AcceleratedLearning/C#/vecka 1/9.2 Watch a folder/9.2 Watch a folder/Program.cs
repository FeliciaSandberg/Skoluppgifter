using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_Watch_a_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher();
            watcher.Path = @"C:\TMP";
            watcher.EnableRaisingEvents = true;

            Console.WriteLine($"I'm watching this folder: {watcher.Path}");

            watcher.Changed += FileChanged;
            watcher.Created += FileCreated;
            watcher.Deleted += FileDeleted;
            watcher.Renamed += FileRenamed;
            
            Console.ReadKey();
        }

        private static void FileRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File {e.OldName} was renamed to {e.Name}");
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} was deleted");
        }

        private static void FileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} was created");
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.FullPath} has been changed");
        }
    }
}
