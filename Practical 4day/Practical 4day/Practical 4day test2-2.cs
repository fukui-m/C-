using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4day
{
    abstract class PlaneFigure
    {
        protected double width = 0;
        protected double heigth = 0;
        protected double area = 0;


        public double Width
        {
            set { width = value; }
            get { return width; }
        }
        public double Heigth
        {
            set { heigth = value; }
            get { return heigth; }
        }
        public abstract double Area { set; get; }
    }
}
