using System;

namespace Exercise4
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			//Exercise6
			Console.Write("Write Angle which is to be converted into sin or cosin  ");
			float angle = float.Parse (Console.ReadLine ());


			float angleInDegreesSin = (float)Math.Sin(angle * (Math.PI/180)) ;      //bcz it returns double so convert it into float 
			float angleInDegreesCos = (float)Math.Cos(angle * (Math.PI/180)) ;



			Console.WriteLine("sin of "+ angle+ " is " + angleInDegreesSin);

			Console.WriteLine("cosine of "+ angle+ " is " + angleInDegreesCos);




			//Exercise4
			int firstAltitude;
			int secondAltitude;
		

			Console.WriteLine ("Hello World!");

			Console.Write("Enter altitude of first location: ");
			firstAltitude=int.Parse(Console.ReadLine());


			Console.Write("Enter altitude of second location: ");
			secondAltitude=int.Parse(Console.ReadLine());


			int altitudeChange = secondAltitude - firstAltitude;

			Console.WriteLine ("The altitude change will be  " + "" + altitudeChange);







		}
	}
}
