using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak10.Entities
{
    public class DeathProbability
    {
        public Gender Gender { get; set; }
    
        public int Age { get; set; }

        public double DeathProbabilies { get; set; }
        public double DeathProbabilities { get; internal set; }

        Random rng = new Random(1234);
    }
}
