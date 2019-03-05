using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7day
{
    class _7day_test3_2
    {
        private int firstnumber = 8;
        private int secondnumber = 9;
        
        public int FirstNumber
        { 
            get { return firstnumber; }
        }
        public int SecondNumber
        {
            get { return secondnumber; }
        }
        public int Add
        {
            get { return firstnumber + secondnumber; } 
        }
        public int Sub
        {
            get { return firstnumber - secondnumber; }
        }
    }    
}