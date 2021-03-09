using System;
using System.Linq;

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
		
		
		static bool CheckWinCondition(string[,] board, string PlayerToken)
					{
			for (int columns = 0; columns < 3; columns++)
			{
				if (board[columns, 0] == PlayerToken && board[columns, 1] == PlayerToken && board[columns, 2] == PlayerToken)
										
				{
					return true;
				}
			}

			for (int rows = 0; rows < 3; rows++)
			{
				if (board[0, rows] == PlayerToken && board[1, rows] == PlayerToken && board[2, rows] == PlayerToken)

				{
					return true;
				}

			}
			if (board[0, 0] == PlayerToken && board[1, 1] == PlayerToken && board[2, 2] == PlayerToken				
				|| board[0, 2] == PlayerToken && board[1, 1] == PlayerToken && board[2, 0] == PlayerToken)
			{
				return true;
			}
			return false;
		}

		static Position ReturnPosition(string [,]  array)
		{

		Found:
			Console.WriteLine("podaj pozycje 'o' w lini 'i'");
			string text = Console.ReadLine();
			int position1i;
			bool isNumber = int.TryParse(text, out position1i);
			while (isNumber != true || position1i > array.Rank)
			{
				Console.WriteLine("wprowadziłeś złą wartość");
				Console.WriteLine("podaj pozycje 'o' w lini 'i'");
				text = Console.ReadLine();
				isNumber = int.TryParse(text, out position1i);
			}

			Console.WriteLine(" podaj pozycję 'o' w lini 'j' ");
			string text2 = Console.ReadLine();
			int position1j;
			bool isNumber2 = int.TryParse(text2, out position1j);
			while (isNumber2 != true || position1j > array.Rank)
			{
				Console.WriteLine("wprowadziłeś złą wartość");
				Console.WriteLine("podaj pozycje 'o' w lini 'j'");
				text2 = Console.ReadLine();
				isNumber2 = int.TryParse(text2, out position1j);
			}

			if (array[position1i, position1j] != "[ ]")
			{
				Console.WriteLine("pozycja już zajęta");
				goto Found;
			}
			// metoda ma zwrócić pozycje.
			var position1 = new Position();
			position1.positioni();
			var position2 = new Position();
			position2.positionj();
			return array[position1, position2];
		}
		
		
				

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
				bool isNumber = int.TryParse(text, out position1i);
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
				while (isNumber2 != true || position1j > array.Rank)
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

				CheckWinCondition(array,"[o]");

				if (CheckWinCondition(array,"[o]") == true)
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

				CheckWinCondition(array,"[x]");

				if (CheckWinCondition(array,"[x]") == true)
				{
					Console.WriteLine("'x' won");
					break;
				}

			}

		}
	}
}

