using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentSim
{
    class TradingOffer
    {
        public Country Country { get; set; }

        public RessourceType OffredRessource { get; set; }

        public int Tons { get; set; }
    }
}
