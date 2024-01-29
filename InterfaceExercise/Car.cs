using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
		{
            
		}

        public string TypeOfCar { get; set; }

		public bool IsHybrid { get; set; } = false;

        public int? Year { get; set; } = null;

        public string Model { get; set; }

        public string TypeOfMotor { get; set; } = "gas engine";

        public bool IsDriveable { get; set; }

        public int TopSpeedMPH { get; set; }

        public string Name { get; set; }

        public bool CompanyNameIsVehicleMake { get; set; } = true;

        public string Location { get; set; } = "Detroit";

        public void DisplayDetails()
        {
            Console.WriteLine($"The {Year} {Name} {Model} is a {(IsHybrid? "hybrid " : "")}{TypeOfCar}.");
            if (IsDriveable)
            {
                Console.WriteLine($"Its {TypeOfMotor} can drive up to {TopSpeedMPH} miles per hour!");
            }
            else Console.WriteLine($"Unfortunately, this car is not currently driveable.");
            Console.WriteLine($"{Name} is a manufacturer based in {Location}.");
        }
    }
}

