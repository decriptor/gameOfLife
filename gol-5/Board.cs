using System;

namespace gol5
{
	public class Board
	{
		public int Count {
			get;
			set;
		}

		public void AddCell (Cell cell, int x, int y)
		{
			Count++;
		}
	}

}
