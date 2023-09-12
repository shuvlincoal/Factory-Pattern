using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public int NumTires { get; set; } = 4;

        public void Drive()
        {
            Console.WriteLine("Car Tires are expensive, good I only need four!");
        }

    }
}
