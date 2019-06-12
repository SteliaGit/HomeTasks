using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis
{
    class ConsoleView
    {       
        static void Main(string[] args)
        {    
            int input = 1;
            int subInput = 1;
            Logic logic = new Logic(); ;
            while (input != 7)
            {
                Repository.LoadPassengerCars();
                Repository.LoadTrucks();
                Console.WriteLine(new string('-', 10));
                Console.WriteLine("Taxi park");
                Console.WriteLine(new string('-', 10));
                Console.WriteLine("Main menu:");
                Console.WriteLine("1 - Taxi fleet report");
                Console.WriteLine("2 - Sort cars (by fuel consumption)");
                Console.WriteLine("3 - Search cars (by speed)");
                Console.WriteLine("4 - Add a new car");
                Console.WriteLine("5 - Remove car");
                Console.WriteLine("6 - Total cost of taxis");
                Console.WriteLine("7 - Exit");

                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Report:");
                            Console.WriteLine("1 - Passenger Cars");
                            Console.WriteLine("2 - Trucks");

                            int.TryParse(Console.ReadLine(), out subInput);
                            switch (subInput)
                            {
                                case 1:
                                    {
                                        
                                        logic.ShowPassangerCars(Repository.PassCars);
                                        break;
                                    }
                                case 2:
                                    {
                                        
                                        logic.ShowTruks(Repository.Trucks);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("You entered incorrect data");
                                        Console.WriteLine("To continue, click - ENTER");
                                        Console.ReadKey();
                                        break;
                                    }
                            }                            
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Sort cars (by fuel consumption):");
                            Console.WriteLine("1 - Passenger Cars");
                            Console.WriteLine("2 - Trucks");
                            int.TryParse(Console.ReadLine(), out subInput);
                            switch (subInput)
                            {
                                case 1:
                                    {
                                        logic.Sort(subInput);
                                        break;
                                    }
                                case 2:
                                    {
                                        logic.Sort(subInput);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("You entered incorrect data");
                                        Console.WriteLine("To continue, click - ENTER");
                                        Console.ReadKey();
                                        break;
                                    }
                            }                            
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Search cars (by speed):");
                            Console.WriteLine("1 - Passenger Cars");
                            Console.WriteLine("2 - Trucks");
                            int.TryParse(Console.ReadLine(), out subInput);
                            switch (subInput)
                            {
                                case 1:
                                    {
                                        logic.SearchPassangerCars();
                                        break;
                                    }
                                case 2:
                                    {
                                        logic.SearchTruks();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("You entered incorrect data");
                                        Console.WriteLine("To continue, click - ENTER");
                                        Console.ReadKey();
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            logic.AddCars();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Remove car:");
                            Console.WriteLine("1 - Passenger Cars");
                            Console.WriteLine("2 - Trucks");

                            int.TryParse(Console.ReadLine(), out subInput);
                            switch (subInput)
                            {
                                case 1:
                                    {
                                        logic.ShowPassangerCars(Repository.PassCars);
                                        logic.DeletePassCars();
                                        break;
                                    }
                                case 2:
                                    {
                                        logic.ShowTruks(Repository.Trucks);
                                        logic.DeleteTruck();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("You entered incorrect data");
                                        Console.WriteLine("To continue, click - ENTER");
                                        Console.ReadKey();
                                        break;
                                    }
                                    Console.ReadKey();
                            }

                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine( $"The total cost of all cars is - {logic.TotalCost()} $");
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("The program will now exit. ");
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
                Console.Clear();
            }
        }
    }
}
