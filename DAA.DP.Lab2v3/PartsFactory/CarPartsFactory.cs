using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Lab2v3
{
    public abstract class CarPartsFactory
    {
        public abstract Engine CreateEngine();
        public abstract Rudder CreateRadder();
        public abstract Paint CreatePaint();
        public abstract Wheels CreateWheels();
    }
}
