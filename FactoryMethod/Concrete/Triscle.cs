using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    class Triscle : IVehicle
    {
        private readonly int Wheels;
        public Triscle()
        {
            this.Wheels = 3;
        }
        public int NumberOfWheels()
        {
            return this.Wheels;
        }
        public string VehicleType()
        {
            return "Triscle class";
        }
    }
}
