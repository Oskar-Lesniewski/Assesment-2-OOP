using System;
using System.Collections.Generic;
using System.Linq;

namespace Assesment2
{
    // Class That Houses The Card Pack
    class Pack
    {
        public List<Card> pack { get; set; }
        // Initialising The Initial Card Pack.
        public Pack()
        {
            pack = new List<Card>();
            for (int i = 0; i < 52; i++)
            {
                pack.Add(new Card(i));
            }
        }
        // Shuffle Method.
        public static void shuffleCardPack(int Difficulty, int Correct, int Wrong, int Test)
        {
            // Fisher-Yates shuffle
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
            // Dealing The Right Amount Of Cards, Calling The Deal Method.
            deal(shuffledPack, Difficulty, Correct, Wrong, Test);
        }
        //Deal method.
        public static Card deal(List<Card> list, int Difficulty, int Correct, int Wrong, int Test)
        {
            // Taking The Right Amount Of Elements Of The Shuffled List And Dealing It To Them.
            var deal = list.Take(Difficulty);
            List<Card> dealt = new List<Card>();
            foreach (Card card in deal)
            {
                dealt.Add(card);
                Console.WriteLine(card.Display());
            }
            // Convert The Cards To Numbers And Operators.
            if (Difficulty == 3)
            {

                float Number1 = dealt[0].Value;
                string Operator = dealt[1].Suit;
                float Number2 = dealt[2].Value;
                Conversion.Conversion3(Operator, Number1, Number2, Difficulty, Correct, Wrong, Test);
            }
            else if (Difficulty == 5)
            {
                float Number1 = dealt[0].Value;
                string Operator1 = dealt[1].Suit;
                float Number2 = dealt[2].Value;
                string Operator2 = dealt[3].Suit;
                float Number3 = dealt[4].Value;
                Conversion.Conversion5(Operator1, Operator2, Number1, Number2, Number3, Difficulty, Correct, Wrong, Test);
            }
            return null;  
        }
    }
}
