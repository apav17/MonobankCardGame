using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonobankCardGame.Models
{
    public class Player
    {
        public string name;
        public int chips = 1000;
        public int currentRoundWinChips = 0;

        public Player(string name)
        {
            this.name = name;
        }

        public void MakeBet(int amount, int cardLayout, Round currentRound)
        {
            Bet bet = new Bet(this, amount, cardLayout);
            currentRound.AddBet(bet);
            chips -= amount;
        }
    }
}
