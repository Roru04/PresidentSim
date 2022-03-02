using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentSim
{
    class ResourceDiscovery : Event
    {
        public RessourceType FoundRessourceType { get; set; }

        public int FoundTons { get; set; }

        public override void ExecuteEvent()
        {
            
        }
    }
}
