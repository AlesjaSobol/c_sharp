using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1
{
  abstract class geometrical_figure
  {
        public abstract double Perimetr();
       public abstract double Area();
  }
   
    class Triangle:geometrical_figure
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a+b>c&& a+c>b&& b+c>a)
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                Console.WriteLine("This is not a triangle!");
            }
        }

        public override double Perimetr()
        {
            return A + B + C;
        }

        public override double Area()
        {
            double p;
            p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

    class Square : geometrical_figure
    {
        private double A_sq { get; set; }
        private double B_sq { get; set; }
        private double C_sq { get; set; }
        private double D_sq { get; set; }

        public Square (double a)
        {
            A_sq = a;           
        }

        public override double Perimetr()
        {
            return A_sq + A_sq + A_sq + A_sq;
        }

        public override double Area()
        {
            return Math.Sqrt(A_sq);
        }
    }

   class Rectangle : geometrical_figure
   {
        public double A_rec { get; set; }
        public double B_rec { get; set; }

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

   class Circle : geometrical_figure
    {
        private double A_cir { get; set; }

        public Circle(double a)
        {
            A_cir = a;
        }

        public override double Perimetr()
        {
            return 2 * 3.14 * A_cir;
        }

        public override double Area()
        {
            return 3.14 * Math.Sqrt(A_cir);
        }
    }

    class Rhombus : geometrical_figure
    {
        private double A_rhom { get; set; }
        private double B_rhom { get; set; }
        public Rhombus(double a, double b)
        {
            A_rhom = a;
            B_rhom = b;
        }

        public override double Perimetr()
        {
            return 4 * A_rhom; 
        }

        public override double Area()
        {
            return A_rhom * B_rhom;//base and height
        }
    }

    class trapeze : geometrical_figure
    {
        private double A_tr { get; set; }
        private double B_tr { get; set; }
        private double С_tr { get; set; }
        private double D_tr { get; set; }
        private double High_tr { get; set; }


        public trapeze(double a, double b, double c, double d, double h)
        {
            A_tr = a;
            B_tr = b;
            С_tr = c;
            D_tr = d;
            High_tr = h;
        }

        public override double Perimetr()
        {
            return A_tr + B_tr + С_tr + D_tr;
        }        

        public override double Area()
        {
            return Math.Sqrt(High_tr * (A_tr + B_tr));
        }
    }
}
