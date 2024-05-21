using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonobankCardGame.Models
{
    public class Banker
    {
        private List<string> cardDeck = new List<string> {"2H", "3H", "4H", "5H", "6H", "7H", "JH", "QH", "KH", "AH",
            "2S", "3S", "4S", "5S", "6S", "7S", "JS", "QS", "KS", "AS",
            "2D", "3D", "4D", "5D", "6D", "7D", "JD", "QD", "KD", "AD",
            "2C", "3C", "4C", "5C", "6C", "7C", "JC", "QC", "KC", "AC"};

        public CardLayout dealCardLayout()
        {
            string firstCard = cardDeck[0];
            string secondCard = cardDeck[1];
            cardDeck.RemoveRange(0, 2);
            return new CardLayout(firstCard, secondCard);
        }

        public void ShuffleDeck()
        {
            var deck = new List<string> {"2H", "3H", "4H", "5H", "6H", "7H", "JH", "QH", "KH", "AH",
            "2S", "3S", "4S", "5S", "6S", "7S", "JS", "QS", "KS", "AS",
            "2D", "3D", "4D", "5D", "6D", "7D", "JD", "QD", "KD", "AD",
            "2C", "3C", "4C", "5C", "6C", "7C", "JC", "QC", "KC", "AC"};

            Random.Shared.Shuffle(CollectionsMarshal.AsSpan(deck));
            cardDeck = deck;
        }

        public string OpenGateCard()
        {
            var gateCard = cardDeck[0];
            cardDeck.RemoveAt(0);
            return gateCard;
        }
    }
}
