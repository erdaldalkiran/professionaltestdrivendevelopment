namespace TicTacToe.Services
{
    public class GameWinnerService : IGameWinnerService
    {
        private const char NotWinningSymbol = ' ';

        public char Validate(char[,] gameBoard)
        {
            var currentWinningSymbol = CheckFirstRow(gameBoard);
            if (currentWinningSymbol != NotWinningSymbol) return currentWinningSymbol;

            currentWinningSymbol = CheckFirstColumn(gameBoard);
            if (currentWinningSymbol != NotWinningSymbol) return currentWinningSymbol;

            currentWinningSymbol = CheckDiagonal(gameBoard);
            if (currentWinningSymbol != NotWinningSymbol) return currentWinningSymbol;

            return NotWinningSymbol;
        }

        private static char CheckDiagonal(char[,] gameBoard)
        {
            var diagonalOneChar = gameBoard[0, 0];
            var diagonalTwoChar = gameBoard[1, 1];
            var diagonalThreeChar = gameBoard[2, 2];
            if (diagonalOneChar == diagonalTwoChar && diagonalTwoChar == diagonalThreeChar)
            {
                return diagonalOneChar;
            }
            return NotWinningSymbol;
        }

        private static char CheckFirstColumn(char[,] gameBoard)
        {
            var rowOneFirstChar = gameBoard[0, 0];
            var rowTwoFirstChar = gameBoard[1, 0];
            var rowThreeFirstChar = gameBoard[2, 0];
            if (rowOneFirstChar == rowTwoFirstChar && rowTwoFirstChar == rowThreeFirstChar)
            {
                return rowOneFirstChar;
            }
            return NotWinningSymbol;
        }

        private static char CheckFirstRow(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[0, 0];
            var columnTwoChar = gameBoard[0, 1];
            var columnThreeChar = gameBoard[0, 2];
            if (columnOneChar == columnTwoChar && columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return NotWinningSymbol;
        }
    }
}
