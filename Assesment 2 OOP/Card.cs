namespace Assesment2
{
    // This Class Houses The Cards.
    class Card
    {
        //Base For The Card Class.
        //Value: Numbers 1 - 13.
        //Suit: Numbers 1 - 4.
        public int Value { get; set; }
        public string Suit { get; set; }
        // Val Determined In The Pack Class.
        public Card(int val)
        {
            // Generating The Corresponding Cards To Values And Suits.
            Value = (val % 13) + 1;
            if (val / 13 == 0)
            {
                Suit = "Diamonds";
            }
            else if (val / 13 == 1)
            {
                Suit = "Clubs";
            }
            else if (val / 13 == 2)
            {
                Suit = "Hearts";
            }
            else
            {
                Suit = "Spades";
            }
        }
        // Custom Added Method To Display Ace, Jack, Queen Or King As Well As Making The Numbers In The Same Format.
        public string Display()
        {
            if (Value == 1)
            {
                return "Ace of " + Suit;
            }
            else if (Value == 11)
            {
                return "Jack of " + Suit;
            }
            else if (Value == 12)
            {
                return "Queen of " + Suit;
            }
            else if (Value == 13)
            {
                return "King of " + Suit;
            }
            else
            {
                return Value + " of " + Suit;
            }
        }
    }
}