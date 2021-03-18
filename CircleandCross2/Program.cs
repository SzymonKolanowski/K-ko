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

		static Coordinates ReturnCordinates(string[] array, string PlayerCoordinates)
		{
			Console.WriteLine("podaj pozycję " + PlayerCoordinates + " współrzędnej");
			string text = Console.ReadLine();
			int cordinate;
			bool isCordinates = int.TryParse(text, out cordinate);
			while( isCordinates != true|| cordinate > array.Rank)
			{
				Console.WriteLine("wprowadziłeś złą wartość");
				Console.WriteLine("podaj poprawną wartość " + PlayerCoordinates);
				text = Console.ReadLine();
				isCordinates = int.TryParse(text, out cordinate);
			}
			Coordinates c1 = new Coordinates(cordinate);
			return c1;
		}
		static Position ReturnPosition(string[,] array,string PlayerToken)
		{

		//Found:


			Console.WriteLine("podaj pozycje" + PlayerToken + " w lini i");
			string text = Console.ReadLine();
			int position1i;
			bool isNumber = int.TryParse(text, out position1i);
			while (isNumber != true || position1i > array.Rank)
			{
				Console.WriteLine("wprowadziłeś złą wartość");
				Console.WriteLine("podaj pozycje " + PlayerToken + " w lini 'i'");
				text = Console.ReadLine();
				isNumber = int.TryParse(text, out position1i);
			}
			// sprawić by nie było dupikacji kodu na lini 'i' i na lini 'j' utwórz funkcję
			Console.WriteLine(" podaj pozycję " + PlayerToken + " w lini 'j' ");
			string text2 = Console.ReadLine();
			int position1j;
			bool isNumber2 = int.TryParse(text2, out position1j);
			while (isNumber2 != true || position1j > array.Rank)
			{
				Console.WriteLine("wprowadziłeś złą wartość");
				Console.WriteLine("podaj pozycje " + PlayerToken + " w lini 'j'");
				text2 = Console.ReadLine();
				isNumber2 = int.TryParse(text2, out position1j);
			}

			while (array[position1i, position1j] != "[ ]")
			{
				
				//goto Found;// zamienić goto na  pętle while
			}

			Position p1 = new Position(position1i, position1j);
			return p1;
			
		}
		static void Main(string[] args)
		{

			string [,] array = new string[3, 3] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
			ShowGameBoard(array);

			for (int GameRound = 1; GameRound <= 5; GameRound++)
			{
			
				var position = ReturnPosition(array,"[o]");
				array[ position.Positionrow , position.Positioncolumn] = "[o]";

				ShowGameBoard(array);

				

				if (CheckWinCondition(array,"[o]") )
				{
					Console.WriteLine("'o' won");
					break;
				}

				if (GameRound == 5)
				{
					Console.WriteLine(" koniec gry - remis");
					break;
				}
								
				var position2 = ReturnPosition(array,"[x]");
				array[ position2.Positionrow,position2.Positioncolumn] = "[x]";

				ShowGameBoard(array);
						
				
				if (CheckWinCondition(array,"[x]"))
				{
					Console.WriteLine("'x' won");
					break;
				}

			}

		}
	}
}

