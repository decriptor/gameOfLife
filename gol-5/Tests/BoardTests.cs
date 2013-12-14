using NUnit.Framework;
using System;
using gol5;

namespace Tests
{
	[TestFixture]
	public class BoardTests
	{

		[Test]
		public void CanCreate ()
		{
			Board board = new Board ();
			Assert.IsNotNull (board);
		}
	}
}
