using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_2
{
    class Rectangle : geometrical_figure
    {
        public double A_rec;
        public double B_rec;

        public Rectangle(double a, double b)
        {
            A_rec = a;
            B_rec = b;
        }

        public override double Perimetr()
        {
            return 2 * (A_rec + B_rec);
        }

        public override double Area()
        {
            return A_rec * B_rec;
        }
    }
}
