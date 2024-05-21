using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MonobankCardGame.Models
{
    public class Game
    {
        public readonly List<Player> players;
        public readonly Banker banker = new Banker();
        private readonly List<Round> rounds = new List<Round>();

        public Game(List<Player> players)
        {
            this.players = players;
            banker.ShuffleDeck();
        }

        public Round? CurrentRound => rounds.LastOrDefault();

        public int PlayersWithChipsCount => players.Count(player => player.chips != 0);

        public Player? GetWinner()
        {
            int maxChips = players.Max(player => player.chips);
            List<Player> playersWithMaxChips = players.Where(player => player.chips == maxChips).ToList();
            Player? winner = playersWithMaxChips.Count == 1 ? playersWithMaxChips[0] : null;
            return winner;
        }

        public void StartRound()
        {
            var numberRound = CurrentRound is null ? 1 : CurrentRound.number + 1;
            if (rounds.Count < 6)
            {
                var firstCardLayout = banker.dealCardLayout();
                var secondCardLayout = banker.dealCardLayout();
                var newRound = new Round(numberRound, firstCardLayout, secondCardLayout);
                rounds.Add(newRound);

                foreach (Player player in players)
                {
                    player.currentRoundWinChips = 0;
                }
            }
            else
            {
                throw new Exception("The maximum number of rounds has been reached.");
            }
        }

        public void Restart()
        {
            foreach (Player player in players)
            {
                player.chips = 1000;
            }
            banker.ShuffleDeck();
            rounds.Clear();
        }
    }
}
