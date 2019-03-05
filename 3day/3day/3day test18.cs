using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3day
{
    class _3day_test18
    {
        static void Main(string[] args)
        {
            var minInputValue = -10;
            var maxInputValue = 35;

            Console.Write("温度を入力してください({0}～{1}):", minInputValue.ToString(), maxInputValue.ToString());

            int firstInputValue;
            if (!int.TryParse(Console.ReadLine(), out firstInputValue))
            {
                Console.WriteLine("数値を入力してください。");
                Console.ReadLine();
                return;
            }

            if (firstInputValue < minInputValue || maxInputValue < firstInputValue)
            {
                Console.WriteLine("適切な値を入力してください。");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("摂氏{0}度", firstInputValue);

            int degreesOfWinterday = 0;
            int degreesOfSummerday = 25;
            int degreesOfHotday = 30;

            if (firstInputValue < degreesOfWinterday)
            {
                Console.WriteLine("真冬日です");
            }
            else if (degreesOfSummerday <= firstInputValue && firstInputValue < degreesOfHotday)
            {
                Console.WriteLine("");
                Console.WriteLine("夏日です");
            }
            else if (degreesOfHotday <= firstInputValue)
            {
                Console.WriteLine("");
                Console.WriteLine("真夏日です");
            }

            Console.ReadLine();
        }
        }
    }

