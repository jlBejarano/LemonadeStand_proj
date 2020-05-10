using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Weather
    {
      
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
            
        }

        public Weather()
        {
            RandomCondition();
            RandomTempurature();
        }

        private string RandomCondition()
        {
            weatherCondition = weatherConditions[random.Next(weatherConditions.Count)];
            return weatherCondition;
        }
        private void RandomTempurature()
        {
            if (weatherCondition == "Rain")
            {
                weatherTempurature = random.Next(75, 65);
            }
            else if(weatherCondition == "Sunny")
            {
                weatherTempurature = random.Next(95, 100);
            }
            else if(weatherCondition == "Cloudy")
            {
                weatherTempurature = random.Next(80, 85);
            }
            else if(weatherCondition == "Thunderstorm")
            {
                weatherTempurature = random.Next(60, 70);
            }
        }

    }
} 
        
        

            
            
               

            
              
        
            
        
        
        
        
        

        
        

        
        
            
        
        
        
            
            
            
        

    

