using System;

namespace CircleandCross2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("CircleandCross");

			//string[,] array = new string [3, 3];

			string[,] array = new string[3,3] { {"x","o","o" }, {"x","x","o"}, {"x","o","o" } };
			Console.WriteLine("dzięki za pomoc");





			for (int i = 0; i < 3; i++)
			{

				Console.WriteLine(array);

			}

			//for (int i = 0; i < array.Length; i++)
			//{
			//	string arr = array[i];
			//}


		}
	}
}
