using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test5
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
            } while (word != (""));
            wordList.RemoveAll(judge);
            foreach(string w in wordList)
            {
                Console.Write(w+" ");
            }
            Console.ReadLine();
            bool judge (String s)
            {
                return s.Length>=5;
            }
        }
    }
}
