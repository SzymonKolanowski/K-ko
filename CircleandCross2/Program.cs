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
			







			for (int i = 0; i <3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					string arr = array[i,j];
					Console.Write(arr)
						;
				}
				Console.WriteLine();
				

			}

			Console.WriteLine("podaj pozycje 'o' ");
		}
	}
}
