using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle OrderTires(int numTires)
        {


            switch (numTires)
            {
                case 2:
                    return new Motorcyle();
                case 4:
                    return new Car();
                case 14:
                    return new BigRig();
                default:
                    return new Car();
            }//switch


        }//Method
    }//Class
}//Namespace
