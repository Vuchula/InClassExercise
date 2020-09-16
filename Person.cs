using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExercise
{
	class Person
	{
		public string name;
		public Person() : base()
		{
			Console.WriteLine("Enter your name:");
			name = Console.ReadLine();
		}
	}
}
