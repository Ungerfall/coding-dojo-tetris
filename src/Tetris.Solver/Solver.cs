using TetrisClient;

namespace Tetris.Solver
{
	public class Solver : AbstractSolver
	{
		public Solver(string server) : base(server)
		{
		}

		protected internal override Command Get(Board gameBoard)
		{
			return Command.MoveTo(Direction.Left);
		}
	}
}
