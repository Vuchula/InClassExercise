using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExercise
{
	class Car : Vehicle
	{
		public string make;
		public string type;
		public int model_year;
		public int num_doors;

		public void CarDetails()
		{
			Console.WriteLine("Enter Make:");
			make = Console.ReadLine();
			Console.WriteLine("Enter Type:");
			type = Console.ReadLine();
		}
	}
}
