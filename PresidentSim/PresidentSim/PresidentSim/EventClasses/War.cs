using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentSim
{
    class War : Event
    {
        public Country Agressor { get; set; }

        public Country Victim { get; set; }




        public override void ExecuteEvent()
        {
            
        }

    }
}
