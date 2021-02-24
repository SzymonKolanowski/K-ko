using System;

namespace CircleandCross2
{
	class Program
	{
		 static void GameBoard (string[,] board)
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

		static void Main(string[] args)
		{




			string [,] array = new string[3, 3] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };
			GameBoard(array);






			for (int a = 1; a <= 5; a++)
			{

				

				Console.WriteLine("podaj pozycje 'o' w lini 'i'");
				string text = Console.ReadLine();
				int position1i = int.Parse(text);
				Console.WriteLine(" podaj pozycję 'o' w lini 'j' ");
				string text2 = Console.ReadLine();
				int position1j = int.Parse(text2);

				if (array[position1i, position1j] == "[ ]")
				{
					array[position1i, position1j] = "[o]";
				}
				else
				{
					Console.WriteLine("pozycja już zajęta");
				}

				GameBoard(array);

				if (array[0, 0] == "[o]" && array[0, 1] == "[o]" && array[0, 2] == "[o]"
					|| array[1, 0] == "[o]" && array[1, 1] == "[o]" && array[1, 2] == "[o]"
					|| array[2, 0] == "[o]" && array[2, 1] == "[o]" && array[2, 2] == "[o]"
					|| array[0, 0] == "[o]" && array[1, 1] == "[o]" && array[2, 2] == "[o]"
					|| array[0, 0] == "[o]" && array[1, 0] == "[o]" && array[2, 0] == "[o]"
					|| array[0, 1] == "[o]" && array[1, 1] == "[o]" && array[2, 1] == "[o]"
					|| array[0, 2] == "[o]" && array[1, 2] == "[o]" && array[2, 2] == "[o]"
					|| array[0, 2] == "[o]" && array[1, 1] == "[o]" && array[2, 0] == "[o]")
				{
					Console.WriteLine("wygrał 'o' , koniec gry");
					break;
				}

				if (a == 5)
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

				if (array[position2i, position2j] == "[ ]")
				{
					array[position2i, position2j] = "[x]";
				}
				else
				{
					Console.WriteLine("pozycja już zajęta");
				}

				GameBoard(array);

				


			}



		}
	}
}

