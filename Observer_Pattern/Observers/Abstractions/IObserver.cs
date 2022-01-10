using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Observers.Abstractions
{
    internal interface IObserver
    {
        void Update(double temperature, double humiditty, double pressure);
    }
}
