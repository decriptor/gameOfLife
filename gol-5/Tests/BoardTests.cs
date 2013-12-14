using NUnit.Framework;
using System;
using gol5;

namespace Tests
{
	[TestFixture]
	public class BoardTests
	{
		Board _board;

		[SetUp]
		public void SetUp ()
		{
			_board = new Board ();
		}

		[Test]
		public void CanCreate ()
		{
			Assert.IsNotNull (_board);
		}

		[Test]
		public void CanAddCell ()
		{
			_board.AddCell (new Cell (true));
			Assert.That (_board.Count == 1);
		}

		[Test]
		public void Can_Add_Two_Cells_To_Board ()
		{
			_board.AddCell (new Cell (true));
			_board.AddCell (new Cell (true));

			Assert.That (_board.Count == 2);
		}
	}
}
