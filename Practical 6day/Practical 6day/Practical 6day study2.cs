using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_study2
    {
        static void Main(string[] args)
        {
            List<String> a = new List<string>();
            a.Add("Taro");
            a.Add("Hanako");
            a.Add("Jiro");
            a.Add("Kaoru");
            a.Remove("Taro");
            a.RemoveAt(1);
            foreach(String s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
