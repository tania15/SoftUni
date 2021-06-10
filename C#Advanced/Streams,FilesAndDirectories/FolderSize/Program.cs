using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles(@"C:\Users\V330\Desktop\xxx");
            double totalSize = 0;

            foreach (var fileName in fileNames)
            {
                FileInfo info = new FileInfo(fileName);
                totalSize += info.Length;
            }

            //Console.WriteLine(totalSize / 1024 / 1024);
            Console.WriteLine(totalSize);
        }
    }
}
