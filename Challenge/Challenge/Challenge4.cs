using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Challenge4
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            decimal dice = rnd.Next(1, 1001);
            int digitnum = 0;
            Console.Write("{0}は", dice);
            do
            {
                digitnum++;
                dice = dice/10;
            }
            while (1<=dice);
            Console.Write("{0}桁です", digitnum);
            Console.ReadLine();
        }
    }
}
