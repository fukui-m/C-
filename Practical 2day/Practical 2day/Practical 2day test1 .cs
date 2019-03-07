using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2day
{
    class Practical_2day_test1
    {
        static int Add(int firstInputValue,int secondInputValue)
        {
            return firstInputValue + secondInputValue;
        }
        static int Sub(int firstInputValue, int secondInputValue)
        {
            return firstInputValue - secondInputValue;
        }
        static void Main(string[] args)
        {
            Console.Write("a=");
            int firstInputValue = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int secondInputValue = int.Parse(Console.ReadLine());
            Console.WriteLine("a + b = {0}",Add(firstInputValue, secondInputValue));
            Console.WriteLine("a - b = {0}",Sub(firstInputValue, secondInputValue));
            Console.ReadLine();
        }
    }
}
