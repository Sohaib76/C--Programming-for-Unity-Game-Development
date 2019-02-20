using System;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // print welcome message
			Console.WriteLine("Welcome PLayers to your favourite game Blackjack !!!");
            // create and shuffle a deck
			Console.WriteLine();
			Console.WriteLine("Shuffling The Cards");
			Deck deck = new Deck();
			deck.Shuffle();
		

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
			Console.WriteLine();
			Console.WriteLine("Dealing The Cards");


			//deck.Print();
			Console.WriteLine ();

			Card card1ForPLayer1 = deck.TakeTopCard();
			String P1card1 = card1ForPLayer1.Rank + " of "+ card1ForPLayer1.Suit;

			Card card1ForPlayer2 = deck.TakeTopCard();
			String P2card1 = card1ForPlayer2.Rank + " of "+ card1ForPlayer2.Suit;

			Card card1ForPlayer3 = deck.TakeTopCard();
			String P3card1 = card1ForPlayer3.Rank + " of "+ card1ForPlayer3.Suit;

			Card card2ForPLayer1 = deck.TakeTopCard();
			String P1card2 = card2ForPLayer1.Rank + " of "+ card2ForPLayer1.Suit;

			Card card2ForPlayer2 = deck.TakeTopCard();
			String P2card2 = card2ForPlayer2.Rank + " of "+ card2ForPlayer2.Suit;

			Card card2ForPlayer3 = deck.TakeTopCard();
			String P3card2 = card2ForPlayer3.Rank + " of "+ card2ForPlayer3.Suit;



			//Deck allCards = card1ForPLayer1, card1ForPlayer2;






            // flip all the cards over
			Console.WriteLine("Flipping the cards over.....");
			card1ForPLayer1.FlipOver();
			card1ForPlayer2.FlipOver();
			card1ForPlayer3.FlipOver();
			card2ForPLayer1.FlipOver();
			card2ForPlayer2.FlipOver();
			card2ForPlayer3.FlipOver();
			Console.WriteLine();

            // print the cards for player 1
			Console.WriteLine("Player One Cards:");
			Console.WriteLine(P1card1);
			Console.WriteLine(P1card2);
			Console.WriteLine();
            // print the cards for player 2
			Console.WriteLine("Player Two Cards:");
			Console.WriteLine(P2card1);
			Console.WriteLine(P2card2);
			Console.WriteLine();

            // print the cards for player 3
			Console.WriteLine("Player Three Cards:");
			Console.WriteLine(P3card1);
			Console.WriteLine(P3card2);

            Console.WriteLine();
        }
    }
}
