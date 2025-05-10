using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FsWorker.GetCurrentDir());
            foreach (var item in FsWorker.ListOfFiles(FsWorker.GetCurrentDir()))
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
