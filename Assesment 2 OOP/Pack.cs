using System;
using System.Collections.Generic;
using System.Linq;

namespace Assesment2
{
    class Pack
    {
        public List<Card> pack { get; set; }

        // Initialising the initial card pack
        public Pack()
        {
            pack = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                pack.Add(new Card(i));
            }
        }

        // Method for shuffling the cards
        public static void shuffleCardPack(int Difficulty, int Correct, int Wrong)
        {
            // Fisher-Yates shuffle
            // Randomly selecting items in a pack, adding to a new list and deleting the same item from the old pack
            Random r = new Random();
            Pack pack = new Pack();
            List<Card> shuffledPack = new List<Card>();
            for (int New = pack.pack.Count(); New > 0; New--)
            {
                int Old = r.Next(New);
                var temp = pack.pack[Old];
                shuffledPack.Add(temp);
                pack.pack.RemoveAt(Old);

            }
            pack.pack = shuffledPack;
            Console.WriteLine("\nPack was shuffled.\n");
            // Dealing a card, calling the deal method
            deal(shuffledPack, Difficulty, Correct, Wrong);
        }
        //Deal method
        public static Card deal(List<Card> list, int Difficulty, int Correct, int Wrong)
        {
            // Taking the first element of the shuffled list that the user picked, and dealing it to them
            var deal = list.Take(Difficulty);
            List<Card> dealt = new List<Card>();
            foreach (Card card in deal)
            {
                dealt.Add(card);
                Console.WriteLine(card.Display());
            }
            // Convert the cards to numbers and operators.
            if (Difficulty == 3)
            {

                float Number1 = dealt[0].Value;
                string Operator = dealt[1].Suit;
                float Number2 = dealt[2].Value;
                Conversion.Conversion3(Operator, Number1, Number2, Difficulty, Correct, Wrong);
            }
            else if (Difficulty == 5)
            {
                float Number1 = dealt[0].Value;
                string Operator1 = dealt[1].Suit;
                float Number2 = dealt[2].Value;
                string Operator2 = dealt[3].Suit;
                float Number3 = dealt[4].Value;
                Conversion.Conversion5(Operator1, Operator2, Number1, Number2, Number3, Difficulty, Correct, Wrong);
            }
            return null;  

        }
    }
}
