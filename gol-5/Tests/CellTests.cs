using NUnit.Framework;
using System;
using gol5;

namespace Tests
{
	[TestFixture ()]
	public class CellTests
	{
		[Test ()]
		public void A_cell_can_be_constructed ()
		{
			var cell = new Cell (true);
			Assert.That (cell, Is.Not.Null); 
		}

		[Test]
		public void A_cell_knows_if_its_alive ()
		{
			var cell = new Cell (true);
			Assert.That (cell.IsAlive); 
		}

		[Test]
		public void A_cell_can_evolve ()
		{
			var cell = new Cell (true);
			Cell newCell = cell.Evolve (0);
			Assert.That (newCell != cell);
		}

		[TestCase(0, false)]
		[TestCase(1, false)]
		[TestCase(2, true)]
		[TestCase(3, true)]
		[TestCase(4, false)]
		[TestCase(5, false)]
		[TestCase(6, false)]
		[TestCase(7, false)]
		[TestCase(8, false)]
		public void A_living_cell_can_evolve (int livingNeighbors, bool alive)
		{
			var cell = new Cell (true);
			Cell newCell = cell.Evolve (livingNeighbors);
			Assert.That (newCell.IsAlive,Is.EqualTo(alive));
		}

		[TestCase(0, false)]
		[TestCase(1, false)]
		[TestCase(2, false)]
		[TestCase(3, true)]
		[TestCase(4, false)]
		[TestCase(5, false)]
		[TestCase(6, false)]
		[TestCase(7, false)]
		[TestCase(8, false)]
		public void A_dead_cell_can_evolve (int livingNeighbors, bool alive)
		{
			var cell = new Cell (false);
			Cell newCell = cell.Evolve (livingNeighbors);
			Assert.That (newCell.IsAlive,Is.EqualTo(alive));
		}

	}
}
