using System;
using System.Collections.Generic;

namespace A1
{
	class Program
	{
		static void Main(string[] args)
		{
			// take cards number from the users
			Console.WriteLine("Enter the number of cards to pick: ");
			// declare line variable for take a input from the user
			string line = Console.ReadLine();
			// if loop is use for valid user numbers
			if (int.TryParse(line, out int numCards))
			{
				// foreach use for output 
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}
		}
	}

	public static class SubsequenceFinder
	{
		/// <summary>
		/// Determines whether a list of integers is a subsequence of another list of integers
		/// </summary>
		/// <param name="seq">The main sequence of integers.</param>
		/// <param name="subseq">The potential subsequence.</param>
		/// <returns>True if subseq is a subsequence of seq and false otherise.</returns>
		public static bool IsValidSubsequeuce(List<int> seq, List<int> subseq)
		{
			// I have confusion about this sequence and subsequence in cards in this method.
			// Also I didn't know how to use Testing.
			throw new NotImplementedException();
		}
	}

	class CardPicker
	{
		static Random random = new Random(1);

		public static string[] PickSomeCards(int numCards)
		{
			int totalcards = 52; // totalcards is 52 in one deck
			string[] user_input_cards = new string[totalcards];

			// this for loop is take numbers form the user and print random cards
			for (int i = 1; i <= numCards; i++)
			{
				// In this random_face variable I will call RandomValue function.
				string random_face = RandomValue();

				// In this random_suit variable I will call RandomSuit function.
				string random_suit = RandomSuit();

				user_input_cards[i - 1] = random_face + " of " + random_suit;
			}

			// this user_input_cards return user cards output
			return user_input_cards;
		}

		private static string RandomValue()
		{
			// this face varible is use for store the faces.
			var face = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };

			// this face_index is select any random values from face list
			int faces_index = random.Next(face.Count);

			// this return funcion return the random values of users.
			return face[faces_index];
		}

		private static string RandomSuit()
		{
			// this face varible is use for store the suits.
			var suit = new List<string> { "Hearts", "Clubs", "Diamonds", "Spades" };

			// this face_index is select any random values from face list
			int suits_index = random.Next(suit.Count);

			// this return funcion return the random values of users.
			return suit[suits_index];
		}
	}
}
