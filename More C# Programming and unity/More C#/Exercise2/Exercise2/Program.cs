﻿using System;
using ConsoleCards;
using System.Collections.Generic;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 Solution
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Practice using lists
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // create deck and hand
            Deck deck = new Deck();
			List<Card> hand = new List<Card>();

            deck.Shuffle();

            // add card, flip over, and print
			hand.Add(deck.TakeTopCard());
            hand[0].FlipOver();
            hand[0].Print();
            Console.WriteLine();

            // add another card, flip over, and print both cards
			hand.Add(deck.TakeTopCard());
            hand[1].FlipOver();
            hand[1].Print();
            hand[0].Print();

            Console.WriteLine();
        }
    }
}
