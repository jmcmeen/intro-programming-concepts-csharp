namespace _12_2_EnumeratedTypes
{
    public class Deck
    {
        public Card[]? Cards { get; set; }

        public Deck() 
        {
            int deckSize = Enum.GetValues(typeof(Rank)).Length * Enum.GetValues(typeof(Suit)).Length;
            Cards = new Card[deckSize];

            int currentIndex = 0;

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Cards[currentIndex] = new Card(rank, suit);
                    currentIndex++;
                }
            }
        }

        public void PrintCards()
        {
            foreach(Card c in Cards)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
