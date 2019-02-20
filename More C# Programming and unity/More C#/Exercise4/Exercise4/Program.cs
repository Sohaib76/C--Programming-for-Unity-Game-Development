using System;
using ConsoleCards;
using System.Collections.Generic;


namespace Exercise4
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.Write ("Enter a lower bound: ");
			int lowerBound = int.Parse (Console.ReadLine());

			Console.Write ("Enter a upper bound: ");
			int upperBound = int.Parse (Console.ReadLine ());

			// print numbers in range
			for (int i = lowerBound; i <= upperBound; i++)
			{
				Console.WriteLine(i);
			}


			//Game Object
			Deck deck = new Deck();
			List<Card> list = new List<Card> ();

			deck.Shuffle ();

			//3
			for (int i = 0; i < 5; i++) {
				list.Add (deck.TakeTopCard ());
			}

			//flip all card
			for (int i = 0; i < list.Count; i++) {
				list [i].FlipOver ();
			}

			foreach (Card card in list) {
				card.Print ();
			}

			Console.WriteLine ();









			Console.WriteLine ("Hello World!");
		}
	}
}
