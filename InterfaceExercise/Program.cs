using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IVehicle>();

            Car c1 = new Car()
            {
                Year = 2018, Name = "Toyota", Model = "Prius",
                IsHybrid = true, TypeOfCar = "hatchback",
                Location = "Japan", IsDriveable = true,
                TopSpeedMPH = 112, TypeOfMotor = "4-cylinder engine and electric motor"
            };

            list.Add(c1);

            Truck t1 = new Truck()
            {
                Year = 2021, Name = "Ford", Model = "F-150",
                NumberOfAxles = 2, TypeOfTruck = "pickup",
                IsDriveable = true,
                TopSpeedMPH = 108, TypeOfMotor = "gas or diesel engine (you have options!)"
            };

            list.Add(t1);

            SUV s1 = new SUV()
            {
                Year = 2014, Name = "Mazda", Model = "CX-5",
                NumberOfSeats = 5, HasTowHitch = false,
                Location = "Japan",
                TopSpeedMPH = 126, TypeOfMotor = "2.5L engine"
            };

            list.Add(s1);

            foreach (IVehicle vehicle in list)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
