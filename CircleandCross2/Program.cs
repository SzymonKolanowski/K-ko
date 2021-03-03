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

		static bool ChechWinCondition(string[,] board)
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

		static bool CheckWinCondition2(string[,] board /*string  playerfield*/)
		{
			//for (int columns = 0; columns < 3; columns++)
			//{
			//	if (board[columns, 0] == "[o]" || board[columns, 1] == "[o]" || board[columns, 2] == "[o]"
			//		|| board[columns, 0] == "[x]" || board[columns, 1] == "[x]" || board[columns, 2] == "[x]")
			//	{
			//		return true;
			//	}

			//}

			////for (int rows = 0; rows < 3; rows++)
			////{
			////	if (board [0,rows] =="[o]" || board [1,rows] == "[o]" || board [2,rows] == "[o]"
			////		|| board[0, rows] == "[x]" || board[1, rows] == "[x]" || board[2, rows] == "[x]")
			////	{
			////		return true;
			////	}

			////}
			if (board[0, 0] == "[o]" && board[1, 1] == "[o]" && board[2, 2] == "[o]"
				|| board[0, 0] == "[x]" && board[1, 1] == "[x]" && board[2, 2] == "[x]"
				|| board[0, 2] == "[o]" && board[1, 1] == "[o]" && board[2, 0] == "[o]"
				|| board[0, 2] == "[x]" && board[1, 1] == "[x]" && board[2, 0] == "[x]")
			{
				return true;
			}
			return false;
		}

		//static bool IsCorrectInput(string text,string text2, string[,] board)
		//{
		//	int position1i;
		//	int position1j;
		//	bool isNumber = int.TryParse(text, out position1i);
		//	bool isNumber2 = int.TryParse(text2, out position1j);

		//	for (int i = 0; i < board.GetLength(0); i++)
		//	{
		//		for (int j = 0; j < board.GetLength(1); j++)
		//		{
		//			string arr = board[i, j];
		//			Console.Write(arr);
		//		}
		//		Console.WriteLine();
		//	}

		//	while (isNumber == false || isNumber2 == false || position1i > )
		//	{
		//		return false;
		//	}


		//	return true;

		//}

		static void Main(string[] args)
		{

			string [,] array = new string[3, 3] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
			ShowGameBoard(array);

			for (int GameRound = 1; GameRound <= 5; GameRound++)
			{
			Found:
				Console.WriteLine("podaj pozycje 'o' w lini 'i'");
				string text = Console.ReadLine();
				int position1i ;
				bool isNumber = int.TryParse(text, out  position1i);
				bool comprasion = isNumber != true;
				while (isNumber != true || position1i > array.Rank)
				{
					Console.WriteLine("wprowadziłeś złą wartość");
					Console.WriteLine("podaj pozycje 'o' w lini 'i'");
					text = Console.ReadLine();
					isNumber = int.TryParse(text, out position1i);
				}

				Console.WriteLine(" podaj pozycję 'o' w lini 'j' ");
				string text2 = Console.ReadLine();
				int position1j ;
				bool isNumber2 = int.TryParse(text2, out position1j);
				bool comprasion2 = isNumber2 != true;
				while ( isNumber2 != true || position1j > array.Rank )
				{
					Console.WriteLine("wprowadziłeś złą wartość");
					Console.WriteLine("podaj pozycje 'o' w lini 'j'");
					text2 = Console.ReadLine();
					isNumber2 = int.TryParse(text2, out position1j);
				}
				
				if (array[position1i, position1j] == "[ ]")
				{
					array[position1i, position1j] = "[o]";
				}
				else
				{
					Console.WriteLine("pozycja już zajęta");
					goto Found;
				}

				ShowGameBoard(array);

				CheckWinCondition2(array);

				if (CheckWinCondition2(array) == true)
				{
					Console.WriteLine("'o' won");
					break;
				}

				if (GameRound == 5)
				{
					Console.WriteLine(" koniec gry - remis");
					break;
				}

			Found2:
				Console.WriteLine("podaj pozycję znaku 'x' w lini i");
				string text3 = Console.ReadLine();
				int position2i;

				bool isNumber3 = int.TryParse(text3, out position2i);
				bool comprasion3 = isNumber3 != true;
				while (isNumber3 != true || position2i > array.Rank)
				{
					Console.WriteLine("wprowadziłeś złą wartość");
					Console.WriteLine("podaj pozycje 'x' w lini 'i'");
					text3 = Console.ReadLine();
					isNumber3 = int.TryParse(text3, out position2i);
				}


				Console.WriteLine("podaj pozycję znaku 'x' w lini j");
				string text4 = Console.ReadLine();
				int position2j;

				bool isNumber4 = int.TryParse(text4, out position2j);
				bool comprasion4 = isNumber4 != true;
				while (isNumber4 != true || position2j > array.Rank)
				{
					Console.WriteLine("wprowadziłeś złą wartość");
					Console.WriteLine("podaj pozycje 'x' w lini 'j'");
					text4 = Console.ReadLine();
					isNumber4 = int.TryParse(text4, out position2j);
				}


				if (array[position2i, position2j] == "[ ]")
				{
					array[position2i, position2j] = "[x]";
				}
				else
				{
					Console.WriteLine("pozycja już zajęta");
					goto Found2;
				}
				
				ShowGameBoard(array);

				CheckWinCondition2(array);

				if (CheckWinCondition2(array) == true)
				{
					Console.WriteLine("'x' won");
					break;
				}

			}

		}
	}
}

