using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis
{
    class Logic
    {   
        public void AddCars()
        {
            int input = 1;
            while (input != 3)
            {
                Console.Clear();
                Console.WriteLine("Which car do you want to add");
                Console.WriteLine("1 - PassengerCar");
                Console.WriteLine("2 - Truck");
                Console.WriteLine("3 - Exit to main menu");

                int.TryParse(Console.ReadLine(), out input);

                switch (input)
                {
                    case 1:
                        {
                            PassengerCar passengerCar = new PassengerCar();
                            passengerCar.CreateCar();                                                       
                            break;
                        }
                    case 2:
                        {
                            Truck truck = new Truck();
                            truck.CreateCar();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Will now exit to main menu. ");
                            Console.WriteLine("To continue, click - ENTER");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have entered incorrect data, try again");
                            Console.WriteLine("To continue, click - ENTER");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
        public void DeletePassCars()
        {
            int ID;
            int inputID;
            Console.WriteLine("Input ID to remove");
            int.TryParse(Console.ReadLine(), out inputID);
            foreach (var item in Repository.PassCars)
            {
                ID = int.Parse(item.ID.ToString());
                if (ID != inputID)
                {
                    continue;
                }
                else
                {
                    item.IsDelited = 0; 
                }
            }
            Repository.SaveDeletePass();
        } // Удаление происходит с помощью перевода ID в 0
        public void DeleteTruck()
        {
            int ID;
            int inputID;
            Console.WriteLine("Input ID to remove");
            int.TryParse(Console.ReadLine(), out inputID);
            foreach (var item in Repository.Trucks)
            {
                ID = int.Parse(item.ID.ToString());
                if (ID != inputID)
                {
                    continue;
                }
                else
                {
                    item.IsDelited = 0;
                }
            }
            Repository.SaveDeleteTruck();
        }// Удаление происходит с помощью перевода IsDelited в 0
        public void ShowPassangerCars(List<PassengerCar> passCar)
        {
            
            Console.WriteLine("   ID\t|\tModel \t |\t Number of seats \t| Fuel consumption. litrs/ 100 km |\tSpeed\t|\tCost $");
            Console.WriteLine("");
            foreach (PassengerCar item in passCar)
            {
                if (item.IsDelited == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"   {item.ID}\t  \t{item.Model}\t\t\t{item.Seats}\t\t\t\t{item.Fuel}\t\t\t{item.Speed}\t\t\t{item.Cost}");
                }               
            }
            Console.WriteLine("To continue, click - ENTER");
            Console.ReadKey();
        }
        public void ShowTruks(List<Truck> truckCar)
        {
            Console.WriteLine("   ID\t|\tModel \t |\t    Сarrying  kg\t| Fuel consumption. litrs/ 100 km |\tSpeed\t|\tCost $");
            Console.WriteLine("");
            foreach (Truck item in truckCar)
            {
                if (item.IsDelited == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"   {item.ID}\t  \t{item.Model}\t\t\t{item.Сarrying}\t\t\t\t{item.Fuel}\t\t\t{item.Speed}\t\t\t{item.Cost}");
                }
            }
            Console.WriteLine("To continue, click - ENTER");
            Console.ReadKey();
        }
        public void ShowPassangerCars(IOrderedEnumerable<PassengerCar> input) // Перегрузка метода для сортировки
        {            
            Console.WriteLine("   ID\t|\tModel \t |\t Number of seats \t| Fuel consumption. litrs/ 100 km |\tSpeed\t|\tCost $");
            Console.WriteLine("");
            foreach (PassengerCar item in input)
            {
                if (item.IsDelited == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"   {item.ID}\t  \t{item.Model}\t\t\t{item.Seats}\t\t\t\t{item.Fuel}\t\t\t{item.Speed}\t\t\t{item.Cost}");
                }
            }
            Console.ReadKey();
        }
        public void ShowTruks(IOrderedEnumerable<Truck> input)  // Перегрузка метода для сортировки
        {
            Console.WriteLine("   ID\t|\tModel \t |\t    Сarrying  kg\t| Fuel consumption. litrs/ 100 km |\tSpeed\t|\tCost $");
            Console.WriteLine("");
            foreach (Truck item in input)
            {
                if (item.IsDelited == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"   {item.ID}\t  \t{item.Model}\t\t\t{item.Сarrying}\t\t\t\t{item.Fuel}\t\t\t{item.Speed}\t\t\t{item.Cost}");
                }
            }
            Console.ReadKey();
        }
        public void Sort(int input)
        {
            var sortedPass = from car in Repository.PassCars
                         orderby car.Fuel
                         select car;
            var sortedTruks = from car in Repository.Trucks
                         orderby car.Fuel
                         select car;
            if (input == 1)
            {
                ShowPassangerCars(sortedPass);
            }
 
            else
            {
                ShowTruks(sortedTruks);
            }           
        }
        public int  TotalCost()
        {
            int cost;
            int resultPassCars = 0;
            foreach (var item in Repository.PassCars)
            {
                if (item.IsDelited == 0)
                {
                    continue;
                }
                else
                {
                    cost = int.Parse(item.Cost.ToString());
                    resultPassCars = resultPassCars + cost;
                }
            }
            int result = resultPassCars;
            foreach (var item in Repository.Trucks)
            {
                if (item.IsDelited == 0)
                {
                    continue;
                }
                else
                {
                    cost = int.Parse(item.Cost.ToString());
                    result = result + cost;
                }
            }
            return result;
        }       
        public void SearchPassangerCars()
        {
            int InputSpeed;
            int speed;
            Console.WriteLine("Enter maximum speed");
            int.TryParse(Console.ReadLine(), out InputSpeed);
            List<PassengerCar> passengers = new List<PassengerCar>();
            foreach (var item in Repository.PassCars)
            {                
                speed = int.Parse(item.Speed.ToString());
                if (speed != InputSpeed)
                {
                    continue;
                }
                else
                {
                    passengers.Add(new PassengerCar()
                    {
                        ID = int.Parse(item.ID.ToString()),
                        Model = item.Model,
                        Seats = int.Parse(item.Seats.ToString()),
                        Fuel = double.Parse(item.Fuel.ToString()),
                        Speed = speed,
                        Cost = double.Parse(item.Cost.ToString()),
                        IsDelited = int.Parse(item.IsDelited.ToString())
                    });
                }
            }
            if (passengers.Count == 0)
            {
                Console.WriteLine("There is no car with such speed in the database");
                Console.WriteLine("To continue, click - ENTER");
                Console.ReadKey();
            }
            else
            {
                ShowPassangerCars(passengers);
            }
            
        }
        public void SearchTruks()
        {
            int InputSpeed;
            int speed;
            Console.WriteLine("Enter maximum speed");
            int.TryParse(Console.ReadLine(), out InputSpeed);
            List<Truck> Trucks = new List<Truck>();
            foreach (var item in Repository.Trucks)
            {
                speed = int.Parse(item.Speed.ToString());
                if (speed != InputSpeed)
                {
                    continue;
                }
                else
                {
                    Trucks.Add(new Truck()
                    {
                        ID = int.Parse(item.ID.ToString()),
                        Model = item.Model,
                        Сarrying = int.Parse(item.Сarrying.ToString()),
                        Fuel = double.Parse(item.Fuel.ToString()),
                        Speed = speed,
                        Cost = double.Parse(item.Cost.ToString()),
                        IsDelited = int.Parse(item.IsDelited.ToString())
                    });
                }
            }
            if (Trucks.Count == 0)
            {
                Console.WriteLine("There is no car with such speed in the database");
                Console.WriteLine("To continue, click - ENTER");
                Console.ReadKey();
            }
            else
            {
                ShowTruks(Trucks); 
            }
            
        }
    }
}
