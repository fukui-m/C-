using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1day
{
    class Practical_1day_study1
    {
        private string name = "";
        private int age = 0;
        public Practical_1day_study1() : this("名無し", 0)
        {
            Console.WriteLine("引数なしコンストラクタ");
        }
        public Practical_1day_study1(string name,int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("引数ありコンストラクタ name:{0} age:{1}", name, age);
        }
        public void ShowAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", name, age);
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
    }
}
