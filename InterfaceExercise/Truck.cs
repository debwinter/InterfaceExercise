using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
            
		}

		public int NumberOfAxles { get; set; } = 2;

		public string TypeOfTruck { get; set; }

        public int? Year { get; set; } = null;

        public string Model { get; set; }

        public string TypeOfMotor { get; set; } = "diesel engine";

        public bool IsDriveable { get; set; }

        public int TopSpeedMPH { get; set; }

        public string Name { get; set; }

        public string Location { get; set; } = "Detroit";

        public void DisplayDetails()
        {
            Console.WriteLine($"The {Year} {Name} {Model} is a {NumberOfAxles}-axle {TypeOfTruck}.");
            if (IsDriveable)
            {
                Console.WriteLine($"Its {TypeOfMotor} can drive up to {TopSpeedMPH} miles per hour!");
            }
            else Console.WriteLine($"Unfortunately, this car is not currently driveable.");
            Console.WriteLine($"{Name} is a manufacturer based in {Location}.");
        }
    }
}

