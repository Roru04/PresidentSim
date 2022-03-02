using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentSim
{
    public class Event
    {
        public int Severity { get; set; }

        public List<Country> AffectedCountries;

        public string Title { get; set; }

        public string Description { get; set; }


        public EventType EventType { get; set; }


        public virtual void ExecuteEvent()
        {

        }


    }
}
