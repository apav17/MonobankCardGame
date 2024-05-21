using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonobankCardGame.Models
{
    public class CardLayout
    {
        public readonly string firstCard;
        public readonly string secondCard;

        public CardLayout(string firstCard, string secondCard)
        {
            this.firstCard = firstCard;
            this.secondCard = secondCard;
        }
    }
}
