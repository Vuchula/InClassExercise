using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExercise
{
	class Vehicle
	{
		public float registration_number;
		public string color;

		public void Details()
		{
			Console.WriteLine("Reg Num:" + registration_number);
			Console.WriteLine("Color:" + color);
		}
	}
}
