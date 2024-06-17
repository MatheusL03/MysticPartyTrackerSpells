using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Model
{
    public class Character
    {
        public Character(string name, int level, string @class, string race)
        {
            Name = name;
            Level = level;
            Class = @class;
            Race = race;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }

        
       
    }
}
