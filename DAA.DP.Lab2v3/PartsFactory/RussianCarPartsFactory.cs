using DAA.DP.Lab2v3.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAA.DP.Lab2v3.Factory
{
    class RussianCarPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            return new PetrolEngine();
        }

        public override Rudder CreateRadder()
        {
            return new LeftRudder();
        }

        public override Paint CreatePaint()
        {
            return new BluePaint();
        }

        public override Wheels CreateWheels()
        {
            return new MediumWheels();
        }
    }
}
