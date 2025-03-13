using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIceTask
{
    class Abstract
    {
        public string Name { get; set; }

        public Abstract(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
