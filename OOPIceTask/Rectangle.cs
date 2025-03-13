using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIceTask
{
    class Rectangle : Abstract, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(string name, double length, double width) : base(name)
        {
            Length = length;
            Width = width;
        }


      

        public void CalculateArea()
        {
            double area = Length * Width;
            Console.WriteLine($"Area: {area}");
        }
    }
}
