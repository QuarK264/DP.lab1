using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Lab2v3
{
    abstract class MazdaFactory
    {
        public Car GetCar(string type)
        {
            Car car = CreateCar(type);

            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.ChooseRudder();
            car.Paint();
            car.InstallWheels();

            return car;
        }

        protected abstract Car CreateCar(string type);
    }
}
