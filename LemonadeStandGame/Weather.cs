using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Weather
    {
        //public string weatherAtmosphere;
        public string weatherCondition;
        public int weatherTempurature;
        Random random = new Random();
        private List<string> weatherConditions;

        public Weather(string weatherCondition, int weatherTempurature, List<string> weatherConditions)
        {
            List<string> weatherReport = new List<string>();
            weatherReport.Add("Rain");
            weatherReport.Add("Sunny");
            weatherReport.Add("Cloudy");
            weatherReport.Add("Thunderstorm");
            GenerateRandomweatherCondition();
            GenerateRandomweatherTempurature();


        }

        

            //public string WeatherCondition { get { return weatherCondition; } set { weatherCondition = value; } }
            //public int WeatherTempurature { get { return WeatherTempurature; } set { weatherTempurature = value; } }


        public string GenerateRandomweatherCondition()
        {
            weatherCondition = weatherConditions[random.Next(weatherConditions.Count)];
            return weatherCondition;
        }

        public void GenerateRandomweatherTempurature()
        {
            if (weatherCondition == "Rain")
            {
                weatherTempurature = random.Next(70, 85);
            }
            else if (weatherCondition == "Sunny")
            {
                weatherTempurature = random.Next(95, 80);
            }
            else if (weatherCondition == "Cloudy")
            {
                weatherTempurature = random.Next(75, 85);
            }
            else if (weatherCondition == "Thunderstorm")
            {
                weatherTempurature = random.Next(60, 70);
            }
        }
    }
} 
        
        

            
            
               

            
              
        
            
        
        
        
        
        

        
        

        
        
            
        
        
        
            
            
            
        

    

