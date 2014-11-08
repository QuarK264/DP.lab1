using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Lab2v3.Cars
{
    class Mazda3 : Car
    {
        private CarPartsFactory PartsFactory;

        public Mazda3(CarPartsFactory factory)
        {
            Name = "Mazda3";
            Body = "Sedan";

            PartsFactory = factory;
        }

        public override void Configure()
        {
            Console.WriteLine("Configuring {0}", Name);
            Console.WriteLine("Body is: {0}", Body);

            Engine = PartsFactory.CreateEngine();
            PaintColor = PartsFactory.CreatePaint();
            Wheels = PartsFactory.CreateWheels();
        }
    }
}
