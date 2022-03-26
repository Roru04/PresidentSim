using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentSim
{
    public class Event
    {
        public double Severity { get; set; }

        public List<Country> AffectedCountries { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }


        public EventType EventType { get; set; }

        public bool IsBad { get; set; }


        public virtual void ExecuteEvent()
        {

        }


    }
}
