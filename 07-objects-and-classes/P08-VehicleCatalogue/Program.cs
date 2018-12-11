using System;
using System.Linq;
using System.Collections.Generic;

namespace P08_VehicleCatalogue
{
    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    public class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var catalog = new Catalog
            {
                Cars = new List<Car>(),
                Trucks = new List<Truck>()
            };

            while (true)
            {
                var vehicle = Console.ReadLine().Split("/");

                if (vehicle[0] == "end")
                {
                    if (catalog.Cars.Count > 0)
                    {
                        List<Car> result = (from currentCar in catalog.Cars
                                            orderby currentCar.Brand ascending
                                            select currentCar).ToList();

                        Console.WriteLine($"Cars:");
                        foreach (var currentCar in result)
                        {
                            Console.WriteLine($"{currentCar.Brand}: " +
                                $"{currentCar.Model} - {currentCar.HorsePower}hp");
                        }
                    }

                    if (catalog.Trucks.Count > 0)
                    {
                        List<Truck> result = (from currentTruck in catalog.Trucks
                                              orderby currentTruck.Brand ascending
                                              select currentTruck).ToList();

                        Console.WriteLine($"Trucks:");
                        foreach (var currentTruck in result)
                        {
                            Console.WriteLine($"{currentTruck.Brand}: " +
                                $"{currentTruck.Model} - {currentTruck.Weight}kg");
                        }
                    }

                    break;
                }

                string brand = vehicle[1];
                string model = vehicle[2];

                if (vehicle[0] == "Car")
                {
                    string horsePower = vehicle[3];
                    var car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };
                    catalog.Cars.Add(car);
                }

                else if (vehicle[0] == "Truck")
                {
                    string weight = vehicle[3];
                    var truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    catalog.Trucks.Add(truck);
                }
            }
        }
    }
}

