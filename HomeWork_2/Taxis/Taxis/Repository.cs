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
        public const string FilePass = @"PassengerCar.dat";
        public const string FileTruck = @"Truck.dat";
        public static List<Truck> Trucks;
        public static List<PassengerCar> PassCars;
       
        public static void LoadPassengerCars()
        {
            PassCars = new List<PassengerCar>();
            PassengerCar passengerCar = new PassengerCar();
            using (StreamReader file = new StreamReader(FilePass))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(';');

                    PassCars.Add(new PassengerCar()
                    {
                        ID = double.Parse(data[0]),
                        Model = data[1],
                        Seats = int.Parse(data[2]),
                        Fuel = double.Parse(data[3]),
                        Speed = double.Parse(data[4]),
                        Cost = double.Parse(data[5]),
                        IsDelited = int.Parse(data[6])
                    });                   
                }
            } 
            
        }
        public static void LoadTrucks()
        {
            Trucks = new List<Truck>();
            Truck truck = new Truck();
            using (StreamReader file = new StreamReader(FileTruck))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(';');

                    Trucks.Add(new Truck()
                    {
                        ID = double.Parse(data[0]),
                        Model = data[1],
                        Сarrying = int.Parse(data[2]),
                        Fuel = double.Parse(data[3]),
                        Speed = double.Parse(data[4]),
                        Cost = double.Parse(data[5]),
                        IsDelited = int.Parse(data[6])
                    });                   
                }
            } 
        }
        // Дозапись в файл PassengerCar
        public static void SavePass(PassengerCar PassCar)
        {
            int idF = 0;
            int id;
            int IsDelited = 1;
            foreach (var item in PassCars)
            {
                idF = int.Parse(item.ID.ToString());
            }
            id = idF + 1;
            using (StreamWriter file = new StreamWriter(FilePass, true, System.Text.Encoding.Default))
            {       
                file.WriteLine($"{id};{PassCar.Model};{PassCar.Seats};{PassCar.Fuel};{PassCar.Speed};{PassCar.Cost};{IsDelited}");
                file.Close();
            }
            Repository.PassCars.Add(PassCar);
        }
 
        // Дозапись в файл Truck
        public static void SaveTrucks(Truck TruckCars)
        {
            int idF = 0;
            int id;
            int IsDelited = 1;
            foreach (var item in Trucks)
            {
                idF = int.Parse(item.ID.ToString());
            }
            id = idF + 1;
            using (StreamWriter file = new StreamWriter(FileTruck, true, System.Text.Encoding.Default))
            {
                file.WriteLine($"{id};{TruckCars.Model};{TruckCars.Сarrying};{TruckCars.Fuel};{TruckCars.Speed};{TruckCars.Cost};{IsDelited}");
                file.Close();
            }
            Repository.Trucks.Add(TruckCars);
        }  
        
        public static void SaveDeletePass()
        {
            using (StreamWriter file = new StreamWriter(FilePass, false, System.Text.Encoding.Default))
            {
                foreach (var item in PassCars)
                {
                    file.WriteLine($"{item.ID};{item.Model};{item.Seats};{item.Fuel};{item.Speed};{item.Cost};{item.IsDelited}");


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
                    file.WriteLine($"{item.ID};{item.Model};{item.Сarrying};{item.Fuel};{item.Speed};{item.Cost};{item.IsDelited}");
                   
                }
                file.Close();
            }
        }

    }
}
