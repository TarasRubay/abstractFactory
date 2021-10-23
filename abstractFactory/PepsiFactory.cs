using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBotle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
    }
}
