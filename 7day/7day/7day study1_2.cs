using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7day
{
    class _7day_study1_2
    {
       static void Main(string[] args)
        {
            _7day_study1 p1, p2;
            p1 = new _7day_study1();
            p2 = new _7day_study1();
            p1.Name = "山田太郎";
            p1.Age = 19;
            p2.SetAgeAndName("佐藤花子", 23);
            p1.ShowAgeAndName();

            Console.WriteLine("名前：{0} 年齢 : {1}", p2.Name, p2.Age);

        }
    }

}
