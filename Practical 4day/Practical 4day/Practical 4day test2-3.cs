using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4day
{
    class Box : PlaneFigure
    {
        public Box(double width,double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }
        
        public override double Area
        {
            set { area = value; }
            get { return width * heigth; }
        }
    }
}
