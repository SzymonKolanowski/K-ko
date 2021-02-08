using System;

namespace CircleandCross2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("CircleandCross");

			//string[,] array = new string [3, 3];

			string[,] array = new string[3,3] { {"[ ]","[ ]","[ ]" }, {"[ ]","[ ]","[ ]"}, {"[ ]","[ ]","[ ]" } };
			







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

			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					
					//if (i == pozycja1i)
					//{
					//	Console.Write("o");
					//}
					 if (j == pozycja1j)
					{
						Console.Write("o");
					}
					else
					{
						string arr1 = array[pozycja1i, pozycja1j];
						Console.Write(arr1);
					}
				}

				//if (i == pozycja1i)
				//{
				//	Console.Write("o");
				//}

				//else
				//{
				//	string arr1 = array[pozycja1j];
				//	Console.Write(arr1);
				//}



				Console.WriteLine();
			
				
			}

		}
	}
}
