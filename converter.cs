using System;
using System.IO;

namespace EUPConverterFivemv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = "D:\\scriptStuff\\convertEUPtoFivem\\"; // Directory path
            string add = "mp_m_freemode_01_p"; // Your 'mp ped'

            if (Directory.Exists(dir))
            {
                foreach (string fileName in Directory.GetFiles(dir))
                {
                    string modified_string = fileName.Replace(dir, "");
                    modified_string = modified_string.Insert(0, add + "^");

                    System.IO.File.Move(fileName, dir + modified_string);
                    Console.WriteLine("File was renamed to: " + modified_string);
                }

                Console.WriteLine("Wollah, your files are now magically renamed!");
            }
            else
            {
                Console.WriteLine("We could not find the requested directory...");
            }
        }
    }
}
