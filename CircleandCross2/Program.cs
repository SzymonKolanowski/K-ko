using System;

namespace CircleandCross2
{
	class Program
	{
		static string[,] Savearr(string[,] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				for (int j = 1; j < array.Length; j++)
				{
					array[i,j] = array[i,j] + array[i-1,j-1];// - wywala błąd " index was outside the bounds of the array" , próbowałem różnych opcji nie mam już pomysłow jak tą funkcję zapisać
				}
				
			}
			return array;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("CircleandCross");
			
			string[,] array = new string[3,3] { {"[ ]","[ ]","[ ]" }, {"[ ]","[ ]","[ ]"}, {"[ ]","[ ]","[ ]" } };
			string[,] Cumulativearr = Savearr(array);
			for (int i = 0; i <array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					string arr = array[i,j];
					Console.Write(arr);
				}
				Console.WriteLine();
			}

			Console.WriteLine("podaj pozycje 'o' w lini 'i'");
			string tekst = Console.ReadLine();
			int pozycja1i = int.Parse(tekst);
			Console.WriteLine(" podaj pozycję 'o' w lini 'j' ");
			string tekst2 = Console.ReadLine();
			int pozycja1j = int.Parse(tekst2);

			//string[] Cumulativearr = Savearr(array); - nie wiem jak zapisać funcję do tablicy 2-wymiarowej i w którym miejscu dać tą funkcję

			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					
					//if (i == pozycja1i)
					//{
					//	Console.Write("o");
					//}
					 if (j == pozycja1j )
					{
						Console.Write("o");
					}
					else
					{
						string arr1 = array[pozycja1i,pozycja1j ];
						Console.Write(arr1);
					}
				}

				if (i == pozycja1i)
				{
					Console.Write("o");
				}

				//else
				//{
				//	string arr1 = array[pozycja1j];
				//	Console.Write(arr1);
				//}



				Console.WriteLine();
			
				
			}

			Console.WriteLine("podaj pozycję znaku 'x' w lini i");
			string tekst3 = Console.ReadLine();
			int pozycja2i = int.Parse(tekst3);
			Console.WriteLine("podaj pozycję znaku 'x' w lini j");
			string tekst4 = Console.ReadLine();
			int pozycja2j = int.Parse(tekst4);


			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (j == pozycja2j)
					{
						Console.WriteLine("x");
					}
					else
					{
						string arr2 = array[pozycja2i, pozycja2j];
					}
				}
			}

		}
	}
}
