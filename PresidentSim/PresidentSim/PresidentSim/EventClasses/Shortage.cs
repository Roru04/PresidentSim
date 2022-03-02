using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentSim
{
    class Shortage : Event
    {
        public string Material { get; set; }

        public EventType Reason { get; set; }

     

        public override void ExecuteEvent()
        {
            
        }
    }
}
