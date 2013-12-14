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

		[Test]
		public void A_cell_can_evolve_based_on_zero ()
		{
			var cell = new Cell (true);
			Cell newCell = cell.Evolve (0);
			Assert.That (!newCell.IsAlive);
		}

		[Test]
		public void A_cell_can_evolve_based_on_two_neigbers ()
		{
			var cell = new Cell (true);
			Cell newCell = cell.Evolve (2);
			Assert.That (newCell.IsAlive);
		}

	}
}
