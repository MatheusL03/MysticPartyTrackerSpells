using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Model
{
    public class Dice
    {
        public int Side { get; set; }

        public Dice (int side)
        {
            Side = side;
        }

        public int Roll() 
        {
            return new Random().Next (1, Side + 1);
        }
    }
}
