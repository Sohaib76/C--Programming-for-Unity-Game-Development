using System;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {

			Deck myDeck = new Deck ();

			Card[] cards = new Card[5];

			myDeck.Shuffle ();

			Card topCard = myDeck.TakeTopCard();

			cards[0] = topCard;

			cards [0].FlipOver ();
			cards [0].Print ();

			Console.WriteLine ();

			//Problem 3
			Card topCard2 = myDeck.TakeTopCard();
			cards [1] = topCard2;
			cards [1].FlipOver ();

			cards [0].Print ();
			cards [1].Print ();

			Console.WriteLine ();



        }
    }
}
