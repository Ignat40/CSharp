using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace FinalPrep
{
    class Deck
    {
        private Card[]? cards;
        public Deck()
        {
            cards = new Card[52];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    cards[i * 13 + j - 1] = new Card((CardSuits)i, (CardRanks)j);
                }
            }
        }
        public Card GetCard(int cardNum)
        {
            if(cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw
                    (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
        }

        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
            bool[] isAssigned = new bool[52];
            Random searchGen = new Random();
            for(int i = 0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while(foundCard == false)
                {
                    destCard = searchGen.Next(52);
                    if(isAssigned[destCard] == false)
                        foundCard = true;
                }
                isAssigned[destCard] = true; 
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);
        }

    }
}