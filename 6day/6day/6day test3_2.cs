using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6day
{
    class _6day_test3_2
    {
        private readonly decimal Pi = 3.14m;

        public decimal Radius { get; set; }
        public decimal Circumference
        {
            get
            {
                return 2 * Pi * Radius;
            }
        }
        public decimal Area
        {
            get
            {
                return Radius * Radius * Pi;
            }
        }
    }
}
