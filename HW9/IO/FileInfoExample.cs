using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HW9
{
    class FileInfoExamlpe
    {
        public static void Execute()
        {
            Console.WriteLine($"===========IO example============");
            string path = @"D:\HW9\FileInfoExample.txt";
            FileInfo fileInfo = new FileInfo(path);
            try
            { 
                fileInfo.Create();
                Console.WriteLine($"File was successfully created");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Directory {Path.GetDirectoryName(path)} does not exists");
                DirectoryInfo dirInfo = new DirectoryInfo(Path.GetDirectoryName(path));
                dirInfo.Create();

                if(dirInfo.Exists)
                {
                    Console.WriteLine($"Directory {Path.GetDirectoryName(path)} was created");
                    fileInfo.Create();
                    if(fileInfo.Exists)
                        Console.WriteLine($"File {path} was created");
                }
            }
        }
    }
}
