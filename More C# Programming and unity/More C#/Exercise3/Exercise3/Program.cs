using System;
using System.Collections.Generic;

namespace Exercise3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			

		 	List<int> myList = new List<int> ();

			for (int i = 1; i <= 10; i++) {
				myList.Add (i);

			}

			for (int i = 0; i < myList.Count; i++) {
				Console.WriteLine (myList[i]);
			}


			Console.WriteLine ();

			for (int i = 10; i >= 0; i -= 2) {
				myList.Remove (i);
			}




			for (int i = 0; i < myList.Count; i++) {
				Console.WriteLine (myList[i]);
			}



			Console.WriteLine ();


			List<int> simple = new List<int> ();

			for (int j = 1; j <= 5; j++) {
				simple.Add(j);
			}




			for (int i = 0; i <= 3; i++) {
				simple.Remove (i);
			}


			for (int i = 0; i < simple.Count; i++) {
				Console.WriteLine (simple[i]);
			}








		 	Console.WriteLine("Hello World!");
		}
	} 
}
