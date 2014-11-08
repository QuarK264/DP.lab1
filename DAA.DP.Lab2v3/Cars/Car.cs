using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Lab2v3
{
    public abstract class Car
    {
        protected string Name = "";
        protected string Body = "";

        protected Engine Engine;
        protected Rudder Rudder;
        protected Paint PaintColor;
        protected Wheels Wheels;

        public abstract void Configure();

        public void AssembleBody()
        {
            Console.WriteLine("Body is assembled");
        }

        public void ChooseRudder()
        {
            Console.WriteLine("Rudder is choosen and placed");
        }

        public void InstallEngine()
        {
            Console.WriteLine("Engine is in its place");
        }

        public void Paint()
        {
            Console.WriteLine("Car is painted");
        }

        public void InstallWheels()
        {
            Console.WriteLine("Wheels are installed");
        }
    }
}