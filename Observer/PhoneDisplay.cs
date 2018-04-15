using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Contracts;
using WeatherStation.Observable;

namespace WeatherStation.Observer
{
    public class PhoneDisplay : IObserver
    {
        public WeatherConditionStation _weatherStation;

        public PhoneDisplay(WeatherConditionStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        public void Update()
        {
            _weatherStation.GetTemperature();
        }
    }
}
