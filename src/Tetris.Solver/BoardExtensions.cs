using System.Collections;
using System.Collections.Generic;
using TetrisClient;

namespace Tetris.Solver
{
	public static class BoardExtensions
	{
		public static Point GetSuitableBottommostFreeSpaces(this Board board)
		{
			return true;
			board.GetFreeSpace();

		}

		public static IEnumerable<Point> GetReachableFreeSpace(this Board board)
		{
			var element = board.GetAt(3,4);

		}
	}
}