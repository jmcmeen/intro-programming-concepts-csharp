namespace _12_2_EnumeratedTypes
{
    public class Card
    {
        public Rank Rank { get; set; }

        public Suit Suit { get; set; }

        public Card(Rank rank, Suit suit) 
        { 
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
