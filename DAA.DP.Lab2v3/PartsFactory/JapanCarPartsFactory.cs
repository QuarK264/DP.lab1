using DAA.DP.Lab2v3.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAA.DP.Lab2v3.Factory
{
    class JapanCarPartsFactory : CarPartsFactory
    {        
        public override Engine CreateEngine()
        {
            return new DieselEngine();
        }

        public override Rudder CreateRadder()
        {
            return new RightRudder();
        }

        public override Paint CreatePaint()
        {
            return new WhitePaint();
        }

        public override Wheels CreateWheels()
        {
            return new BigWheels();
        }
    }
}
