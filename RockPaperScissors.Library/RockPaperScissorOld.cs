using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Library
{

    public class RockPaperScissorOld
    {
        public string PlayGame(string playerMove, string opponentMove)
        {
            string results = String.Empty;

            results = WhenPlayerWins(playerMove, opponentMove, results);
            results = WhenPlayerLoses(playerMove, opponentMove, results);
            results = WhenPlayerEqualsOpponent(playerMove, opponentMove, results);

            return results;
        }

        private static string WhenPlayerEqualsOpponent(string playerMove, string opponentMove, string results)
        {
            if (playerMove == opponentMove)
            {
                results = "Tie";
            }

            return results;
        }

        private static string WhenPlayerLoses(string playerMove, string opponentMove, string results)
        {
            if (playerMove == "Paper" && opponentMove == "Scissors" || playerMove == "Rock" && opponentMove == "Paper" || playerMove == "Scissors" && opponentMove == "Rock")
            {
                results = "Player Loses";
            }

            return results;
        }

        private static string WhenPlayerWins(string playerMove, string opponentMove, string results)
        {
            if (playerMove == "Rock" && opponentMove == "Scissors" || playerMove == "Scissors" && opponentMove == "Paper" || playerMove == "Paper" && opponentMove == "Rock")
            {
                results = "Player Wins";
            }

            return results;
        }
    }
}