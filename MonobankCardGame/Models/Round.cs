using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonobankCardGame.Models
{
    public class Round
    {
        public readonly int number;
        public readonly CardLayout firstCardLayout;
        public readonly CardLayout secondCardLayout;
        private readonly List<Bet> bets = new List<Bet>();
        public bool firstCardLayoutWin;
        public bool secondCardLayoutWin;

        public Round(int number, CardLayout firstCardLayout, CardLayout secondCardLayout)
        {
            this.number = number;
            this.firstCardLayout = firstCardLayout;
            this.secondCardLayout = secondCardLayout;
        }

        public void AddBet(Bet bet)
        {
            bets.Add(bet);
        }

        public void CalculateBets(string gateCard)
        {
            foreach (Bet bet in bets)
            {
                var cardLayout = bet.cardLayout == 1 ? firstCardLayout : secondCardLayout;
                if (cardLayout.firstCard[1] == gateCard[1] || cardLayout.secondCard[1] == gateCard[1])
                {
                    bet.player.currentRoundWinChips += 2 * bet.amount;
                    bet.player.chips += 2 * bet.amount;
                }
            }

            firstCardLayoutWin = firstCardLayout.firstCard[1] == gateCard[1] || firstCardLayout.secondCard[1] == gateCard[1];
            secondCardLayoutWin = secondCardLayout.firstCard[1] == gateCard[1] || secondCardLayout.secondCard[1] == gateCard[1];
        }
    }
}
