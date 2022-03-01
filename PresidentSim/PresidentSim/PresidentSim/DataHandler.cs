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

                main = JsonSerializer.Deserialize<MainClass>(jsonString);

            }
            catch (Exception ex)
            {
                main.Money = 500;
                main.Mood = 60;
                string dataJson = JsonSerializer.Serialize(main);


            


                File.WriteAllText(@"..\..\..\Data\MainClassData.json", dataJson);

            }






            return main;
        }

        public static void WriteJsonData(MainClass main)
        {
            string jsonData = JsonSerializer.Serialize(main);

            File.WriteAllText(@"..\..\..\Data\MainClassData.json", jsonData);
        }
    }
}

