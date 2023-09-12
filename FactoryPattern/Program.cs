using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Program
    {

        public static void TakeOrder()
        {

            Console.WriteLine("Welcome to Tires-R-US!");
            Console.WriteLine("Enter the number of tires you need, Ex: 4> ");
            string? response = Console.ReadLine();


        }


        static void Main(string[] args)
        {
            //1. Make interface
            //2. create classes
            //3. create the factor

            //string? response = "";
            int nbrTires = 0;


            Console.WriteLine("Welcome to Tires-R-US!");
            Console.WriteLine("Enter the number of tires you need, Ex: 4> ");
            nbrTires = int.Parse(Console.ReadLine());
            Console.WriteLine($"You ordered >{nbrTires}< ");
            Console.ReadLine();

            IVehicle customerOrder = VehicleFactory.OrderTires(nbrTires);

            customerOrder.Drive();



        }
    }
}
