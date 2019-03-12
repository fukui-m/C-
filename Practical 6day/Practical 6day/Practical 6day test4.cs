using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test4
    {
        static void Main(string[] args)
        {
            List<String> wordList = new List<String>();
            var word = "";
            do
            {
                Console.Write("文字列を入力:");
                word = Console.ReadLine();
                wordList.Add(word);
            } while (word!=(""));
            Console.WriteLine("");
            foreach(string a in wordList)
            {
                Console.Write("{0} ", a);
            }
            Console.ReadLine();
        }
    }
}
