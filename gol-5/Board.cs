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

		public Cell GetCell (int i, int i2)
		{
			return new Cell (true);
		}
	}

}
