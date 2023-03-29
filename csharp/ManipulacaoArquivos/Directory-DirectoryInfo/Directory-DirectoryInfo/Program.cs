using System;
using System.IO;
using System.Collections.Generic;

 namespace DicerctoryDirectoryInfo {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\myfolder";

            try {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); 
                //pode usar o var como tipo, ele irá fazer a inferência de tipo
                Console.WriteLine("Folders:");
                foreach (string s in folders) Console.WriteLine(s);

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string s in files) Console.WriteLine(s);

                Directory.CreateDirectory(path + "\\newfolder"); //ou @"\newfolder" @"c:\temp\myfolder\newfolder"
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}