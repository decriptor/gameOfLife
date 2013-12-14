using System;

namespace gol5
{
	public class Cell
	{
		public Cell (bool isAlive)
		{
			IsAlive = isAlive;
		}

		public bool IsAlive {
			get;
			private set;
		}

		public Cell Evolve (int livingNeighbors)
		{
			return new Cell (livingNeighbors >= 2 && livingNeighbors < 4);
		}
	}

}

