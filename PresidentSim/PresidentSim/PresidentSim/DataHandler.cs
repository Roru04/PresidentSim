using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace PresidentSim
{
    public static class DataHandler
    {
        public static MainClass ReadJsonData(MainClass main)
        {
            string jsonString = "";
            try
            {
                jsonString = File.ReadAllText(@"..\..\..\Data\MainClassData.json");
            }
            catch (Exception ex)
            {
                File.Create(@"..\..\..\Data\MainClassData.json");
            }




            main = JsonSerializer.Deserialize<MainClass>(jsonString);




            return main;
        }
    }
}


