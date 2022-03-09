using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PresidentSim
{
    public class MainClass
    {
        public double Money { get; set; }

        public double Mood { get; set; }

        public List<Event> ActiveEvents;

        public int Gold { get; set; }

        public int Uran { get; set; }

        public int Technology { get; set; }

        public string DisplayMoney
        {
            get
            {
                return "Money: " + Money.ToString() + " Bil€";
            }

        }

        public void NextRound()
        {

        }
        


    }
}
