using FactoryMethod.Abstract;
using FactoryMethod.Concrete;
using System;

namespace FactoryMethod // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? inputFromConsole = null;
            Console.WriteLine("Enter the Vahicle Type");
            inputFromConsole = Console.ReadLine();
            IVehicle Type = VehicleFactory.getVehicle(inputFromConsole);
            Console.WriteLine("Type is " + Type.VehicleType());
            Console.WriteLine("Number of Wheel is " +Type.NumberOfWheels());
            Console.ReadKey();

        }
    }
}