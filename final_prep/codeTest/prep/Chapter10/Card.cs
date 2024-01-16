namespace FinalPrep
{
    class Card
    {
        public readonly CardSuits suit; 
        public readonly CardRanks ranks; 
        public Card(CardSuits newSuit, CardRanks newRank)
        {
            suit = newSuit;
            ranks = newRank;
        }

        private Card() {}
        public override string ToString()
        {
            return "The " + ranks + " of " + suit;
        }
    }
}