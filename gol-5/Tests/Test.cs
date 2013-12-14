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
			var cell = new Cell ();
			Assert.That (cell, Is.Not.Null); 
		}

		[Test]
		public void A_cell_knows_if_its_alive ()
		{
			var cell = new Cell ();
			cell.IsAlive = true;
			Assert.That (cell.IsAlive); 
		}

		[Test]
		public void A_cell_can_evolve ()
		{
			var cell = new Cell ();
			Cell newCell = cell.Evolve ();
			Assert.That (newCell != cell);
		}
	}
}
