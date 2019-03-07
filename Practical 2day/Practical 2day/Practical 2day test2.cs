using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2day
{
    class Practical_2day_test2
    {
        static int Mul(int firstInputValue,int secondInputValue,int threeInputValue)
        {
            return firstInputValue * secondInputValue*threeInputValue;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int firstInputValue = rnd.Next(1, 11);
            int secondInputValue = rnd.Next(1, 11);
            int threeInputValue = rnd.Next(1, 11);
            Console.WriteLine("a = "+firstInputValue);
            Console.WriteLine("b = " + secondInputValue);
            Console.WriteLine("c = " + threeInputValue);
            Console.WriteLine("{0} * {1} * {2} = {3}", firstInputValue, secondInputValue, threeInputValue, Mul(firstInputValue, secondInputValue, threeInputValue));
            Console.ReadLine();
        }
    }
}
