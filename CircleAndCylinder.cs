using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CircleAndCylinder
    {
        public class Circle
        {
            public double radius;


            public Circle(double r)
            {
                radius = r;


            }


            public double getArea()
            {
                return Math.PI * radius* radius;
            }
        }

        public class Cylinder
        {
            public Circle dt;
            public double height;
            public string color;

            public Cylinder(double r, double h, string c)
            {
                dt = new Circle(r);
                height = h;
            }
            public Cylinder(double r, double h)
            {
                dt = new Circle(r);
                height = h;
            }
            public Cylinder(double r)
            {
                dt = new Circle(r);

            }



            public double getVolume()
            {
                return dt.getArea() * height;
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                

                Cylinder cylinders = new Cylinder(12.34, 10.0, "blue");
                


                Cylinder[] circles = 
                {
                                new Cylinder(80),

                            new Cylinder(12.3,30.7),
                                    new Cylinder(12.34, 10.0, "blue")
                };

            }
        }
    }
}
