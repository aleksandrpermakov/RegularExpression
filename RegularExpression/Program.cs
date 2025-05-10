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
            Console.WriteLine(FsWorker.GetCurrentDir()); // текущая директория
            foreach (var item in FsWorker.ListOfFiles(FsWorker.GetCurrentDir())) // вывожу названия всех файлов в текущем каталоге и подкаталогах
            {
                Console.WriteLine(item);
            }

            List<string> files = FsWorker.ListOfFiles(FsWorker.GetCurrentDir());
            string pattern = @"[0-9]{3,}\S{0,1}[\*]{1}"; //со звездой
            string pattern2 = @"[0-9]{3,}[\*\.]{0,}\s"; // вместе (со звездой и без)
            foreach (string file in files)
            {
                string text = FsWorker.ReadAllFile(file);
                Console.WriteLine(text);                              //выводим весь текст из файла
                string tasks = FindPattern.Find(text, pattern2);    
                Console.WriteLine(tasks);                           //выводим обработку
                Console.Write($"Количество заданий - {FindPattern.Counter} "); // Завершение задания
                tasks = FindPattern.Find(text, pattern);
                Console.WriteLine($", из них со звездочкой - {FindPattern.Counter}");
            }

        }
    }
}
