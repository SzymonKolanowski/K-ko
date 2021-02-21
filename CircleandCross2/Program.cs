using System;

namespace CircleandCross2
{
	class Program
	{

		static void Main(string[] args)
		{
			try
			{


				Console.WriteLine("CircleandCross");

				string[,] array = new string[3, 3] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };

				for (int i = 0; i < array.GetLength(0); i++)
				{
					for (int j = 0; j < array.GetLength(1); j++)
					{
						string arr = array[i, j];
						Console.Write(arr);
					}
					Console.WriteLine();
				}


				for (int a = 1; a <= 5; a++)
				{

					Console.WriteLine("podaj pozycje 'o' w lini 'i'");
					string tekst = Console.ReadLine();
					int pozycja1i = int.Parse(tekst);
					Console.WriteLine(" podaj pozycję 'o' w lini 'j' ");
					string tekst2 = Console.ReadLine();
					int pozycja1j = int.Parse(tekst2);

					array[pozycja1i, pozycja1j] = "[o]";

					for (int i = 0; i < array.GetLength(0); i++)
					{
						for (int j = 0; j < array.GetLength(1); j++)
						{
							string arr1 = array[i, j];
							Console.Write(arr1);

						}
						Console.WriteLine();
					}

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
					string tekst3 = Console.ReadLine();
					int pozycja2i = int.Parse(tekst3);
					Console.WriteLine("podaj pozycję znaku 'x' w lini j");
					string tekst4 = Console.ReadLine();
					int pozycja2j = int.Parse(tekst4);

					array[pozycja2i, pozycja2j] = "[x]";

					for (int i = 0; i < array.GetLength(0); i++)
					{
						for (int j = 0; j < array.GetLength(1); j++)
						{
							string arr2 = array[i, j];
							Console.Write(arr2);
						}
						Console.WriteLine();
					}

					//if (array[pozycja2i, pozycja2j] == array[pozycja1j, pozycja1j])
					//{
					//	Console.WriteLine("podana pozycja jest już zajęta");
					//	break;
					//}

					if (array[0, 0] == "[x]" && array[0, 1] == "[x]" && array[0, 2] == "[x]"
						|| array[1, 0] == "[x]" && array[1, 1] == "[x]" && array[1, 2] == "[x]"
						|| array[2, 0] == "[x]" && array[2, 1] == "[x]" && array[2, 2] == "[x]"
						|| array[0, 0] == "[x]" && array[1, 1] == "[x]" && array[2, 2] == "[x]"
						|| array[0, 0] == "[x]" && array[1, 0] == "[x]" && array[2, 0] == "[x]"
						|| array[0, 1] == "[x]" && array[1, 1] == "[x]" && array[2, 1] == "[x]"
						|| array[0, 2] == "[x]" && array[1, 2] == "[x]" && array[2, 2] == "[x]"
						|| array[0, 2] == "[x]" && array[1, 1] == "[x]" && array[2, 0] == "[x]")
					{
						Console.WriteLine("wygrał 'x' , koniec gry");
						break;
					}
					//if (array[0, 0] == "[x]" && array[0, 0] == "[o]")
					//{
					//	Console.WriteLine("zająłeś już tą pozycję");
					//}

					//if (array[0, 0] == array[pozycja1i, pozycja1j] && array[0, 0] == array[pozycja2i, pozycja2j])
					//{
					//	Console.WriteLine("pozycja jest już zajeta");
					//	break;
					//}

					if (array[pozycja1i, pozycja1j] == array[pozycja2i, pozycja2j])
					{
						Console.WriteLine("pozycja była już zajęta");
						break;
					}
					//if (pozycja2i == pozycja1i & pozycja2j == pozycja1j | pozycja1i == pozycja2i & pozycja1j == pozycja2j)
					//{
					//	Console.WriteLine("podana współrzędna jest już zajęta ");
					//	break;
					//}
					//if (pozycja1i == pozycja2i && pozycja1j == pozycja2j)
					//{
					//	Console.WriteLine("podana współrzędna jest już zajeta przez 'x'");
					//	break;
					//}

					//if (pozycja1i == pozycja1i && pozycja1j == pozycja1j || pozycja2i == pozycja2i && pozycja2j == pozycja2j)
					//{
					//	Console.WriteLine("już zająłeś tą współrzędną");
					//	break;
					//}

				}

				//if (array[0, 0] == "[o]" && array[0, 0] == "[x]")
				//{
				//	Console.WriteLine("zdublowana pozycja");
				//}
				
			}

			catch (Exception exception)
			{

				Console.WriteLine(exception.Message);
			}

			// - spisać wszystkie warunki wygranej , sprawdzić możliwe błędy, ulepszyć kod.

		}
	}
}
