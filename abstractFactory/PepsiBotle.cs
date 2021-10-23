using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    class PepsiBotle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractCover cover)
        {
            Console.WriteLine($"{this.ToString().Split('.')[1]} interact {water.ToString().Split('.')[1]} and close with {cover.ToString().Split('.')[1]}");
        }
    }
}
