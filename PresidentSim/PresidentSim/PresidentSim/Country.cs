using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentSim
{
    public class Country
    {
        public string Name { get; set; }

        public List<Country> AlliedNations { get; set; }


        public bool IsInWar { get; set; }


        public Country Agressor { get; set; }
    }
}
