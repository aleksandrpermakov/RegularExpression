using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class FindPattern
    {
        static private int counter;
        static public int Counter { get { return counter; } }
        static public string Find(string input, string pattern) //input - текст который обрабатываем |  pattern - обработка(синтаксис regex)
        {
            int _counter = 0;
            string result = string.Empty;
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                result += match.ToString() + "|";
                _counter++;
            }
            //Console.WriteLine($"Всего найдено {counter} совпадений");
            counter = _counter;
            return result;
        }
    }
}
