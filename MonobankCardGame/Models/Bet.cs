using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonobankCardGame.Models
{
    public class Bet
    {
        public readonly int amount;
        public readonly int cardLayout;
        public readonly Player player;

        public Bet(Player player, int amount, int cardLayout)
        {
            this.player = player;
            this.amount = amount;
            if (cardLayout != 1 && cardLayout != 2)
            {
                throw new ArgumentException("Значение cardLayout должно быть равно 1 или 2.");
            }
            this.cardLayout = cardLayout;
        }
    }
}
