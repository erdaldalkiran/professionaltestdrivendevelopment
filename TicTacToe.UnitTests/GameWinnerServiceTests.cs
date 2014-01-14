namespace TicTacToe.UnitTests
{
    using NUnit.Framework;

    using TicTacToe.Services;

    [TestFixture]
    public class GameWinnerServiceTests
    {
        private IGameWinnerService _gameWinnerService;

        private char[,] _gameBoard;

        [SetUp]
        public void SetUp()
        {
            _gameWinnerService = new GameWinnerService();
            _gameBoard = new char[3, 3]
                         {
                             { ' ', ' ', ' ' },
                             { ' ', ' ', ' ' },
                             { ' ', ' ', ' ' }
                         };
        }
        [Test]
        public void NeitherPlayerHasThreeRows()
        {
            const char expected = ' ';
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThePlayerWithAllSpacesInTopRowIsWinner()
        {
            const char expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameBoard[0, i] = expected;
            }
            
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThePlayerWithAllSpacesInFirstColumnIsWinner()
        {
            const char expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameBoard[i, 0] = expected;
            }

            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThePlayerWithAllSpacesInDiagonalIsWinner()
        {
            const char expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameBoard[i, i] = expected;
            }

            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }
    }
}
