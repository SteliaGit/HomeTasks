using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis
{
    class Truck : ICar
    {
        public int ID { get; set; }
        public int Сarrying { get; set; }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Speed { get; set; }
        public double Cost { get; set; }

        public void CreateCar()
        {
            Console.WriteLine("Input model");
            Model = Console.ReadLine();
            try
            {
                Console.WriteLine("Input maximum load capacity");
                Сarrying = int.Parse(Console.ReadLine());
                Console.WriteLine("Input fuel consumption / 100 km");
                Fuel = double.Parse(Console.ReadLine());
                Console.WriteLine("Input maximum speed");
                Speed = double.Parse(Console.ReadLine());
                Console.WriteLine("Input cost");
                Cost = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Сheck the data that you enter!");
            }
            Repository.SaveTrucks(this);

        }
    }
}
