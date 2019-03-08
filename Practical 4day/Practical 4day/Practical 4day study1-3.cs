using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4day
{
    class Sparrow
    {
        private String name = "すずめ";
        public void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
        public String Name
        {
            get { return name; }
        } 
    }
}
