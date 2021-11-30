using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak10.Entities
{
    public class BirthProbability
    {
        public int Age { get; set; }

        public int NbrOfChildren { get; set; }

        public double Birthprobabilities { get; set; }
        public double BirthProbabilities { get; internal set; }

        Random rng = new Random(1234);
    }
}
