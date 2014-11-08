using DAA.DP.Lab2v3.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Lab2v3.Factory
{
    class RussianMazdaFactory : MazdaFactory
    {
        protected override Car CreateCar(string type)
        {
            CarPartsFactory factory = new RussianCarPartsFactory();

            if (type == "Mazda3")
            {
                return new Mazda3(factory);
            }
            else
            {
                if (type == "Mazda6")
                {
                    return new Mazda6(factory);
                }
                else
                {
                    if (type == "CX5")
                    {
                        return new CX5(factory);
                    }
                    else
                    {
                        return new CX9(factory);
                    }
                }
            }
        }
    }
}
