using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIceTask
{
    class Circle : Abstract, ICalculateArea
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }


       

        public void CalculateArea()
        {
            double area = (double.Pi * Radius * Radius);
            Console.WriteLine($"Area: {area:F2}");
        }
    }
}
