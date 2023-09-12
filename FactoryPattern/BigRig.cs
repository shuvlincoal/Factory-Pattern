using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class BigRig : IVehicle
    {
        public int NumTires { get; set; } = 14;

        public void Drive()
        {
            Console.WriteLine("Big Rig Tires are expensive, need a bank loan");
        }


    }
}
