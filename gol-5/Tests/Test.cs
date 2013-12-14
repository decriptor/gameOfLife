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
			Cell newCell = cell.Evolve ();
			Assert.That (newCell != cell);
		}
	}
}
