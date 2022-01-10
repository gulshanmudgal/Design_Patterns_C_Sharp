using Observer_Pattern.Observers.Abstractions;
using Observer_Pattern.Subjects.Abstractons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Observers
{
    internal class StatisticsDisplay : IObserver, IDisplay
    {
        private double _maxTemp;
        private double _minTemp = double.MaxValue;
        private double _tempSum = 0.0d;
        private int _numReadings = 0;
        private readonly ISubject _weatherStation;

        public StatisticsDisplay(ISubject weatherStation)
        {
            _weatherStation = weatherStation;

            _weatherStation.RegisterObserver(this);
        }

        public void Update(double temperature, double humiditty, double pressure)
        {
            _tempSum += temperature;
            _numReadings++;

            if(_maxTemp < temperature)
            {
                _maxTemp = temperature;
            }

            if(_minTemp > temperature)
            {
                temperature = _minTemp;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings) + "/" + _maxTemp + "/" + _minTemp);
        }
    }
}
