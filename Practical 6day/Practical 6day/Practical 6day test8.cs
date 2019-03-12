using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6day
{
    class Practical_6day_test8
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> animal = new Dictionary<String, String>();
            animal["cat"] = "猫";
            animal["dog"] = "犬";
            animal["bird"] = "鳥";
            animal["tiger"] = "トラ";
            Console.Write("英語で動物の名前を入力してください:");
            var animalInputName = Console.ReadLine();

            if (animal.Keys.Any(s=> s== animalInputName))
            {
                Console.Write("「{0}」です。", animal[animalInputName]);
            }
            else
            {
                Console.Write("対応するデータは登録されていません。");
            }
            Console.ReadLine();
        }
    }
}
