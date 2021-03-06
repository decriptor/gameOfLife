using NUnit.Framework;
using System;
using gol5;
using System.Security.Cryptography.X509Certificates;

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
			_board.AddCell (new Cell (true), 0, 0);
			Assert.That (_board.Count == 1);
		}

		[Test]
		public void Can_Add_Two_Cells_To_Board ()
		{
			_board.AddCell (new Cell (true), 0, 0);
			_board.AddCell (new Cell (true), 0, 0);

			Assert.That (_board.Count == 2);
		}

		[Test]
		public void Can_get_cell_back_from_board ()
		{
			_board.AddCell (new Cell (true), 0, 0);
			Cell cell = _board.GetCell (0, 0);

			Assert.That (cell != null);
		}
	}
}
