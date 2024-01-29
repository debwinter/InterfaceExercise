using System;
namespace InterfaceExercise
{
	public interface IVehicle : ICompany
	{
        public int? Year { get; set; }

        public string Model { get; set; }

        public string TypeOfMotor { get; set; }

        public bool IsDriveable { get; set; }

        public int TopSpeedMPH { get; set; }

        public void DisplayDetails();
    }
}

