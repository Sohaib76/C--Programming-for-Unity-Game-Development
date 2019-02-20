﻿using System;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
			Deck deck = new Deck();
			deck.Print ();
            // tell the deck to shuffle and print itself

			Console.WriteLine ();

			deck.Shuffle();
			deck.Print ();
            // take the top card from the deck and print the card rank and suit

			Console.WriteLine ();

			Card card1 = deck.TakeTopCard();
			Console.WriteLine (card1.Rank + card1.Suit);

            // take the top card from the deck and print the card rank and suit

			Console.WriteLine ();

			Card card2 = deck.TakeTopCard();
			Console.WriteLine (card2.Rank + card2.Suit);

        }
    }
}
