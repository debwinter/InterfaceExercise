using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
            
		}

		public int NumberOfSeats { get; set; } = 5;

        public bool HasTowHitch { get; set; } = false;

        public int? Year { get; set; } = null;

        public string Model { get; set; }

        public string TypeOfMotor { get; set; } = "gas engine";

        public bool IsDriveable { get; set; }

        public int TopSpeedMPH { get; set; }

        public string Name { get; set; }

        public string Location { get; set; } = "Detroit";

        public void DisplayDetails()
        {
            Console.WriteLine($"The {Year} {Name} {Model} is a {NumberOfSeats}-seat SUV{(HasTowHitch?" with a tow hitch":"")}.");
            if (IsDriveable)
            {
                Console.WriteLine($"Its {TypeOfMotor} can drive up to {TopSpeedMPH} miles per hour!");
            }
            else Console.WriteLine($"Unfortunately, this car is not currently driveable.");
            Console.WriteLine($"{Name} is a manufacturer based in {Location}.");
        }
    }
}

