using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis
{
    class Repository
    {
        public const string FilePass = @"/Taxis/PassengerCar.dat";
        public const string FileTruck = @"/Taxis/Truck.dat";
        public static List<Truck> Trucks = new List<Truck>();
        public static List<PassengerCar> PassCars = new List<PassengerCar>();
       
        public static void LoadPassengerCars()
        {        
        PassengerCar passengerCar = new PassengerCar();
            using (StreamReader file = File.OpenText(FilePass))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(';');

                    PassCars.Add(new PassengerCar()
                    {
                        ID = int.Parse(data[0]),
                        Model = data[1],
                        Seats = int.Parse(data[2]),
                        Fuel = double.Parse(data[3]),
                        Speed = double.Parse(data[4]),
                        Cost = double.Parse(data[5])
                    });                   
                }
            }            
        }
        public static void LoadTrucks()
        {
            Truck trucks = new Truck();
            using (StreamReader file = File.OpenText(FileTruck))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(';');

                    Trucks.Add(new Truck()
                    {
                        ID = int.Parse(data[0]),
                        Model = data[1],
                        Сarrying = int.Parse(data[2]),
                        Fuel = double.Parse(data[3]),
                        Speed = double.Parse(data[4]),
                        Cost = double.Parse(data[5])
                    });
                }
            }
        }

        public static void SavePass(PassengerCar PassCar)
        {
            int id = 0;
            foreach (var item in PassCars)
            {
                id = int.Parse(item.ID.ToString());
            }
            id = id + 1;
            using (StreamWriter file = new StreamWriter(FilePass, true, System.Text.Encoding.Default))
            {       
                file.WriteLine($"{id};{PassCar.Model};{PassCar.Seats};{PassCar.Fuel};{PassCar.Speed};{PassCar.Cost}");
                file.Close();
            }
            Repository.PassCars.Add(PassCar);
        } // Дозапись в файл PassengerCar
        public static void SaveTrucks(Truck TruckCars)
        {
            int id = 0;
            foreach (var item in Trucks)
            {
                id = int.Parse(item.ID.ToString());
            }
            id = id + 1;
            using (StreamWriter file = new StreamWriter(FileTruck, true, System.Text.Encoding.Default))
            {
                file.WriteLine($"{id};{TruckCars.Model};{TruckCars.Сarrying};{TruckCars.Fuel};{TruckCars.Speed};{TruckCars.Cost}");
                file.Close();
            }

        }  // Дозапись в файл Truck
        public static void SaveDeletePass()
        {
            using (StreamWriter file = new StreamWriter(FilePass, false, System.Text.Encoding.Default))
            {
                foreach (var item in PassCars)
                {
                    file.WriteLine($"{item.ID};{item.Model};{item.Seats};{item.Fuel};{item.Speed};{item.Cost}");
                   
                }
                file.Close();
            }             
        }
        public static void SaveDeleteTruck()
        {
            using (StreamWriter file = new StreamWriter(FileTruck, false, System.Text.Encoding.Default))
            {
                foreach (var item in Trucks)
                {
                    file.WriteLine($"{item.ID};{item.Model};{item.Сarrying};{item.Fuel};{item.Speed};{item.Cost}");
                   
                }
                file.Close();
            }
        }

    }
}
