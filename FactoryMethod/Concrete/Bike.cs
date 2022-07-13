using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    class Bike: IVehicle
    {
        private readonly int Wheels;
        public Bike()
        {
            this.Wheels = 2;
        }
        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Byke class";
        }
    }
}
