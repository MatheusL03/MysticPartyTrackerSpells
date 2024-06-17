using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Model
{
    public class Spells
    {
        public class Result 
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public int Level { get; set; }
            public string Url { get; set; }
        }

        public class Response
        {
            public int Count { get; set; }
            public List<Result> Results { get; set; }
        }

    }
}
