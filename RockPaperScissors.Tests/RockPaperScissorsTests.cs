using NUnit.Framework;
using RockPaperScissors.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Tests
{
    [TestFixture]
    public class RockPaperScissorsTests
    {
        [Test]
        public void PlayGame_WhenPaperVsRock_ShouldReturnPlayerWins()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Paper";
            var opponentMove = "Rock";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Wins";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenPaperVsScissors_ShouldReturnPlayerLoses()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Paper";
            var opponentMove = "Scissors";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Loses";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenPaperVsPaper_ShouldReturnTie()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Paper";
            var opponentMove = "Paper";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Tie";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenRockVsRock_ShouldReturnTie()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Rock";
            var opponentMove = "Rock";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Tie";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenScissorsVsScissors_ShouldReturnTie()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Scissors";
            var opponentMove = "Scissors";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Tie";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenRockVsScissors_ShouldReturnPlayerWins()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Rock";
            var opponentMove = "Scissors";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Wins";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenRockVsPaper_ShouldReturnPlayerLoses()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Rock";
            var opponentMove = "Paper";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Loses";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenScissorsVsPaper_ShouldReturnPlayerWins()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Scissors";
            var opponentMove = "Paper";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Wins";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenScissorsVsRock_ShouldReturnPlayerLoses()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Scissors";
            var opponentMove = "Rock";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Loses";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenSpockVsScissors_ShouldReturnPlayerWins()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Spock";
            var opponentMove = "Scissors";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Wins";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenPaperVsSpock_ShouldReturnPlayerWins()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Paper";
            var opponentMove = "Spock";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Wins";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayGame_WhenSpockVsRock_ShouldReturnPlayerWins()
        {
            //Arrange
            var game = InitializeRockPaperScissors();
            var playerMove = "Spock";
            var opponentMove = "Rock";

            //Act
            var actual = game.PlayGame(playerMove, opponentMove);

            //Assert
            var expected = "Player Wins";
            Assert.AreEqual(expected, actual);
        }

        private static RockPaperScissor InitializeRockPaperScissors()
        {
            return new RockPaperScissor();
        }

    }

}
