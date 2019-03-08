using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4day
{
    abstract class Animal
    {
        protected string name = "";
        public abstract void Bark();
        public abstract void Move();
        public void ShowName()
        {
            Console.WriteLine("名前:{0}", name);
        }
    }
}
