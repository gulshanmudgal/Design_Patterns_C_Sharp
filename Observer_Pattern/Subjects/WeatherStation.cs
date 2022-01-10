using Observer_Pattern.Observers.Abstractions;
using Observer_Pattern.Subjects.Abstractons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Subjects
{
    internal class WeatherStation : ISubject
    {
        private readonly List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        public void MeasurementChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementChanged();
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
