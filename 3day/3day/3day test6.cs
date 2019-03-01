using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int firstInputValue = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int SecondInputValue = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0} b={1}",firstInputValue, SecondInputValue);
            if (firstInputValue == SecondInputValue)
            {
                Console.WriteLine("aはbと等しい");
            }else if (firstInputValue > SecondInputValue)
            {
                Console.WriteLine("aはbよりも大きい");
            }else if (firstInputValue < SecondInputValue)
            {
                Console.WriteLine("aはbよりも小さい");
            }
        }
    }
}
