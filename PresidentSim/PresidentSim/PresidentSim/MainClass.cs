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

        
        public string DisplayMoney 
        {
            get
            {
                return "Money: " +  Money.ToString() + " Bil€";
            }
            
              
            
        }


        public MainClass()
        {
            Mood = 60;
            Money = 500;
            
        }


        public MainClass JsonData(MainClass main)
        {
            string jsonString = File.ReadAllText(@"..\..\..\Data\MainClassData.json");


            if (jsonString == "")
            {
               
                string dataJson = JsonSerializer.Serialize(main);

                File.WriteAllText(@"..\..\..\Data\MainClassData.json", dataJson);
            }
            else 
            {
                main = JsonSerializer.Deserialize<MainClass>(jsonString);

            }
            
          
            return main;
        }
    }
}
