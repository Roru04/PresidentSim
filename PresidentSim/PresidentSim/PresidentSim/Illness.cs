using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentSim
{
    class Illness : Event
    {
        public long AffectedPeople { get; set; }

        public double Healing { get; set; }

        public override void ExecuteEvent()
        {
            
        }
    }
}
