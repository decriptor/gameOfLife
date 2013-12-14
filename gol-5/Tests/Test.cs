using NUnit.Framework;
using System;
using gol5;

namespace Tests
{
	[TestFixture ()]
	public class Test
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
		[TestCase(2, true)]
		[TestCase(3, true)]
		public void A_living_cell_can_evolve (int neig, bool alive)
		{
			var cell = new Cell (true);
			Cell newCell = cell.Evolve (neig);
			Assert.That (newCell.IsAlive,Is.EqualTo(alive));
		}
	}
}
