using System;

namespace ProgrammingAssignment1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("                                                         Welcome!");
			Console.WriteLine (" This application will let you calculate the distance between two points and the angle between those points. ");


			Console.Write(" Enter first x value: ");
			float pointX1=float.Parse(Console.ReadLine());

			Console.Write(" Enter first y value: ");
			float pointY1=float.Parse(Console.ReadLine());

			Console.Write(" Enter second x value: ");
			float pointX2=float.Parse(Console.ReadLine());

			Console.Write(" Enter second y value: ");
			float pointY2=float.Parse(Console.ReadLine());


			float deltaX = pointX2 - pointX1;
			float deltaY = pointY2 - pointY1;

			float distanceBetweenPoints = (float)Math.Sqrt((deltaX*deltaX)+(deltaY*deltaY));

			 
			float angleBetweenPoints = (float)Math.Atan2 (deltaY, deltaX) ;

			float angleBetweenPointsInDegrees = angleBetweenPoints * (float)(180 / Math.PI);




			Console.WriteLine (" The distance between the two points is " + distanceBetweenPoints);
			Console.WriteLine (" The angle between the two points is  " + angleBetweenPointsInDegrees + " degrees");

		}
	}
}
