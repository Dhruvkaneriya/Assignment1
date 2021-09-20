using System;
using System.Collections.Generic;

namespace A1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
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
			throw new NotImplementedException();
		}
	}

	class CardPicker
	{
		static Random random = new Random(1);

		public static string[] PickSomeCards(int numCards)
		{
			int totalcards = 52;
			string[] user_input_cards = new string[totalcards];
			for (int i = 1; i <= numCards; i++)
			{
				string random_value = RandomValue();
				string random_suit = RandomSuit();
				user_input_cards[i - 1] = random_value + " of " + random_suit;
			}
			return user_input_cards;
		}

		private static string RandomValue()
		{
			var face = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
			int faces_index = random.Next(face.Count);
			return face[faces_index];
		}

		private static string RandomSuit()
		{
			var suit = new List<string> { "Hearts", "Clubs", "Diamonds", "Spades" };
			int suits_index = random.Next(suit.Count);
			return suit[suits_index];
		}
	}
}
