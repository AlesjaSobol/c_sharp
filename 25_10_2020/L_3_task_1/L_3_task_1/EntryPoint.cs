using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task_1;


namespace L_3_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(11, 4, 9);
            Console.WriteLine("Triangle");
            Console.WriteLine("PERIMETR=" + tr.Perimetr());
            Console.WriteLine("AREA=" + tr.Area());
            Console.WriteLine("=================================");
            Console.WriteLine("Square");
            Square sq = new Square(9.56);
            Console.WriteLine("PERIMETR=" + sq.Perimetr());
            Console.WriteLine("AREA=" + sq.Perimetr());
            Console.WriteLine("=================================");
            Console.WriteLine("Rectangle");
            Rectangle rec = new Rectangle(15.12, 19.17);
            Console.WriteLine("PERIMETR=" + rec.Perimetr());
            Console.WriteLine("AREA=" + rec.Area());
            Console.WriteLine("=================================");
            Console.WriteLine("Circle");
            Circle cir = new Circle(2.16);
            Console.WriteLine("PERIMETR=" + cir.Perimetr());
            Console.WriteLine("AREA=" + cir.Area());
            Console.WriteLine("=================================");
            Console.WriteLine("Rhombus");
            Rhombus rom = new Rhombus(9.19, 2.15);
            Console.WriteLine("PERIMETR=" + rom.Perimetr());
            Console.WriteLine("AREA=" + rom.Area());
            Console.WriteLine("Rhombus");
            trapeze tra = new trapeze (9.19, 2.15, 5.20, 6.32, 8.40);
            Console.WriteLine("PERIMETR=" + tra.Perimetr());
            Console.WriteLine("AREA=" + tra.Area());
        }
    }

    
}
