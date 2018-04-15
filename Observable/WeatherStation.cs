using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Contracts;

namespace WeatherStation.Observable
{
    public class WeatherConditionStation : IObservable
    {
        public int temperature = 0;

        List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public int GetTemperature()
        {
            this.temperature = GenerateRandomTemperature();

            Console.WriteLine("Temp is {0} now", this.temperature);

            return this.temperature;
        }

        public int GenerateRandomTemperature()
        {
            Random rnd = new Random();
            int temp = rnd.Next(1, 13);

            return temp;
        }
    }
}