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
				int position1i = int.Parse(text);
				//bool isNumber = int.TryParse(text, out int number);

				//if (!isNumber)
				//{
				//	break;
				//}
				//bool position1i = int.TryParse(text, out int number);
				//int position1i = int.Parse(text);
				Console.WriteLine(" podaj pozycję 'o' w lini 'j' ");
				string text2 = Console.ReadLine();
				int position1j = int.Parse(text2);

				//if (position1i > 2)
				//{
				//	Console.WriteLine("zbyt wysoka współrzędna");
				//}

				//if (position1j > 2)
				//{
				//	Console.WriteLine("zbyt wysoka współrzędna");
				//}

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
				int position2i = int.Parse(text3);
				Console.WriteLine("podaj pozycję znaku 'x' w lini j");
				string text4 = Console.ReadLine();
				int position2j = int.Parse(text4);

				//if (position1i > 2)
				//{
				//	Console.WriteLine("zbyt wysoka współrzędna");
				//}

				//if (position1j > 2)
				//{
				//	Console.WriteLine("zbyt wysoka współrzędna");
				//}

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

