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
	}
}
