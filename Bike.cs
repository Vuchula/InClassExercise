using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExercise
{
	class Bike : Vehicle
	{
		public string make;
		public string type;
		public int num_gears;

		public void BikeDetails()
		{
			Console.WriteLine("Make:" + make);
			Console.WriteLine("Number of Gears:" + num_gears);
		}
	}
}
