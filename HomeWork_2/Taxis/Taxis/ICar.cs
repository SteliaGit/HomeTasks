using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis
{
    interface ICar
    {
        string Model { get;  set; }
        double Fuel { get; set; }
        double Speed { get; set; }
        double Cost { get; set; }

        void CreateCar();
    }
}
