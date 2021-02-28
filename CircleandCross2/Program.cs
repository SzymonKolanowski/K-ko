using System;

namespace CircleandCross2
{
	class Program
	{
		 static void ShowGameBoard (string[,] board)
		{
			

			for (int i = 0; i < board.GetLength(0); i++)
			{
				for (int j = 0; j < board.GetLength(1); j++)
				{
					string arr = board[i, j];
					Console.Write(arr);
				}
				Console.WriteLine();
			}
			
		}

		static bool GameWonCondition(string[,] board)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					string arr = board[i, j];

					if (board[0, 0] == "[o]" && board[0, 1] == "[o]" && board[0, 2] == "[o]"
					|| board[1, 0] == "[o]" && board[1, 1] == "[o]" && board[1, 2] == "[o]"
					|| board[2, 0] == "[o]" && board[2, 1] == "[o]" && board[2, 2] == "[o]"
					|| board[0, 0] == "[o]" && board[1, 1] == "[o]" && board[2, 2] == "[o]"
					|| board[0, 0] == "[o]" && board[1, 0] == "[o]" && board[2, 0] == "[o]"
					|| board[0, 1] == "[o]" && board[1, 1] == "[o]" && board[2, 1] == "[o]"
					|| board[0, 2] == "[o]" && board[1, 2] == "[o]" && board[2, 2] == "[o]"
					|| board[0, 2] == "[o]" && board[1, 1] == "[o]" && board[2, 0] == "[o]"
					|| board[0, 0] == "[x]" && board[0, 1] == "[x]" && board[0, 2] == "[x]"
					|| board[1, 0] == "[x]" && board[1, 1] == "[x]" && board[1, 2] == "[x]"
					|| board[2, 0] == "[x]" && board[2, 1] == "[x]" && board[2, 2] == "[x]"
					|| board[0, 0] == "[x]" && board[1, 1] == "[x]" && board[2, 2] == "[x]"
					|| board[0, 0] == "[x]" && board[1, 0] == "[x]" && board[2, 0] == "[x]"
					|| board[0, 1] == "[x]" && board[1, 1] == "[x]" && board[2, 1] == "[x]"
					|| board[0, 2] == "[x]" && board[1, 2] == "[x]" && board[2, 2] == "[x]"
					|| board[0, 2] == "[x]" && board[1, 1] == "[x]" && board[2, 0] == "[x]")
					{
						return true;
					}
				}
				
			}
			return false;
		}

		static void Main(string[] args)
		{

			string [,] array = new string[3, 3] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
			ShowGameBoard(array);

			for (int GameRound = 1; GameRound <= 5; GameRound++)
			{

				Console.WriteLine("podaj pozycje 'o' w lini 'i'");
				string text = Console.ReadLine();
				int position1i ;

				bool isNumber = int.TryParse(text, out  position1i);

				if (isNumber == false )
				{
					Console.WriteLine("podałeś literę zamiast liczby");
					

				}

				if (position1i > array.Rank)
				{
					Console.WriteLine("podałeś za dużą liczbę");
				}
				
				Console.WriteLine(" podaj pozycję 'o' w lini 'j' ");
				string text2 = Console.ReadLine();
				int position1j ;

				bool isNumber2 = int.TryParse(text2, out position1j);

				if (isNumber2 == false)
				{
					Console.WriteLine("podałeś literę zamiast liczby");
					
				
				}

				if (position1j > array.Rank)
				{
					Console.WriteLine("podałeś za dużą liczbę");
				}

				if (array[position1i, position1j] == "[ ]")
				{
					array[position1i, position1j] = "[o]";
				}
				else
				{
					Console.WriteLine("pozycja już zajęta");
				}
				
				ShowGameBoard(array);

				GameWonCondition(array);

				if (GameWonCondition(array) == true)
				{
					Console.WriteLine("'o' won");
					break;
				}

				if (GameRound == 5)
				{
					Console.WriteLine(" koniec gry - remis");
					break;
				}

				Console.WriteLine("podaj pozycję znaku 'x' w lini i");
				string text3 = Console.ReadLine();
				int position2i;

				bool isNumber3 = int.TryParse(text3, out position2i);

				if (isNumber3 == false)
				{
					Console.WriteLine("podałeś literę zamiast liczby");
					
				}

				if (position2i > array.Rank)
				{
					Console.WriteLine("podałeś za dużą liczbę");
				}

				Console.WriteLine("podaj pozycję znaku 'x' w lini j");
				string text4 = Console.ReadLine();
				int position2j;

				bool isNumber4 = int.TryParse(text4, out position2j);

				if (isNumber4 == false)
				{
					Console.WriteLine("podałeś literę zamiast liczby");
										
				}

				if (position2j > array.Rank)
				{
					Console.WriteLine("podałeś za dużą liczbę");
				}

				if (array[position2i, position2j] == "[ ]")
				{
					array[position2i, position2j] = "[x]";
				}
				else
				{
					Console.WriteLine("pozycja już zajęta");
				}
				
				ShowGameBoard(array);

				GameWonCondition(array);

				if (GameWonCondition(array) == true)
				{
					Console.WriteLine("'x' won");
					break;
				}

			}

		}
	}
}

