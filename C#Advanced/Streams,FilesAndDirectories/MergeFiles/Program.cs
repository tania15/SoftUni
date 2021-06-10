using System;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] file1 = await File.ReadAllLinesAsync("Input1.txt");
            string[] file2 = await File.ReadAllLinesAsync("Input2.txt");

            string[] output = new string[file1.Length + file2.Length];
            int count = 0;

            for (int i = 0; i < Math.Min(file1.Length, file2.Length); i++)
            {
                output[count] = file1[i];
                output[count + 1] = file2[i];
                count += 2;
            }            

            await File.WriteAllLinesAsync("Output.txt", output);
        }
    }
}
