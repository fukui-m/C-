using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4day
{
    class Triangle : PlaneFigure
    {
        public Triangle(double width, double heigth) : base(width, heigth)
        {
        }
       
        public override double Area
        {
            set { area = value; }
            get { return width * heigth / 2; }
        }
    }
}
