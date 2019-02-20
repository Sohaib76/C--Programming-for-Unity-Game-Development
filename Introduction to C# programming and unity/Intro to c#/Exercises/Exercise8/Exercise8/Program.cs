using System;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    class MainClass
    {


        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
		{
			// initialize random number generator
			RandomNumberGenerator.Initialize ();

			// create two dice
			Die die1 = new Die ();
			Die die2 = new Die ();
			// tell the dice to roll themselves
			die1.Roll ();
			die2.Roll ();

			// print the top sides and the sum of the dice




			Console.WriteLine (die1.TopSide);
			Console.WriteLine (die2.TopSide);

			int sum = die1.TopSide + die2.TopSide;

			Console.WriteLine (sum);

//
//			Console.WriteLine ();
//
//			for (int i = 30; i>=3; i-=3)  {
//				Console.WriteLine (i);
//					
//			}
//
//			Console.WriteLine ();
//
//
//			plus (90);
//
//
//			int x = 3;
//			int y = 4;
//			float f, g, h;
//
//
//
//		
//
//			f = x + y;
//				
//			Console.WriteLine (f);
//
//			g = x - y;
//			   
//			Console.WriteLine (g);
//			h = (float) x / y;
//
//			Console.WriteLine (h);
//
//
//			Console.WriteLine ();
//        }
//
//		//new method
//		public static void plus(int y) {
//			Console.WriteLine(y + 2);
//
//		}

		}
    }
}
