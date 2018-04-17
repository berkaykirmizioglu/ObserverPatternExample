using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeatherStation.Observable;
using WeatherStation.Observer;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherConditionStation weatherStation = new WeatherConditionStation();

            while(true)
            {
                PhoneDisplay phoneDisplay = new PhoneDisplay(weatherStation);

                weatherStation.Add(phoneDisplay);
                weatherStation.Notify();

                Thread.Sleep(5000);
            }
        }
    }
}
