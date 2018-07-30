using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Library
{

    public class RockPaperScissor
    {
        public string PlayGame(string playerMove, string opponentMove)
        {
            if (PlayerHasTied(playerMove, opponentMove))
            {
                return "Tie";
            }
            else if (PlayerHasWon(playerMove, opponentMove))
            {
                return "Player Wins";
            }
            else 
            {
                return "Player Loses";
            }
        }


        private static bool PlayerHasTied(string playerMove, string opponentMove)
        {
            return playerMove == opponentMove;
        }

        private static bool PlayerHasWon(string playerMove, string opponentMove)
        {
            return playerMove == "Rock" && opponentMove == "Scissors" || playerMove == "Scissors" && opponentMove == "Paper" || playerMove == "Paper" && opponentMove == "Rock" || playerMove == "Spock" && opponentMove == "Scissors" || playerMove == "Paper" && opponentMove == "Spock" || playerMove == "Spock" && opponentMove == "Rock";
        }
    }
}