﻿using System;

namespace gol5
{
	public class Cell
	{
		public Cell ()
		{
		}

		public bool IsAlive {
			get;
			set;
		}

		public Cell Evolve ()
		{
			return new Cell ();
		}
	}

}

