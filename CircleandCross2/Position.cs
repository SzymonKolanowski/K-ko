﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CircleandCross2
{
	public class Position
	{

		public int Positionrow;
		public int Positioncolumn;

		public Position(int positionrow, int positioncolumn)
		{
			Positionrow = positionrow;
			Positioncolumn = positioncolumn;
		}

		public Position(string text, string text2)
		{
			Positioncolumn = int.Parse(text);
			Positionrow = int.Parse(text2);
		}
	}	
}
