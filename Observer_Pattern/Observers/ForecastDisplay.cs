using Observer_Pattern.Observers.Abstractions;
using Observer_Pattern.Subjects.Abstractons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Observers
{
    internal class ForecastDisplay : IObserver
    {
        private double _currentPressure = 0.0d;
        private double _lastPressure;
        private readonly ISubject _weatherStation;

        public ForecastDisplay(ISubject weatherStation)
        {
            _weatherStation = weatherStation;
            _weatherStation.RegisterObserver(this);
        }

        public void Update(double temperature, double humiditty, double pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
        }
    }
}
