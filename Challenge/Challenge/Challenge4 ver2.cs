using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Challenge4_ver2
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            decimal dice = rnd.Next(1, 1001);
            Console.Write("{0}は{1}桁です。", dice,dice.ToString().Length);
            Console.ReadLine();
        }
    }
}
