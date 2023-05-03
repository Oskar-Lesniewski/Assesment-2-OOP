using System;

namespace Assesment2
{
    // In This Class Numbers Are Rounded.
    class Round
    {
        // Function To Round Values From 3 Cards.
        public static void Round3(float Temp, float Number1, float Number2, string Operator, int Difficulty, int Correct, int Wrong, int Test)
        {
            double Round = Math.Round(Temp, 0, MidpointRounding.AwayFromZero);
            float Answer = Convert.ToSingle(Round);
            Guess.Guess3(Answer, Number1, Number2, Operator, Difficulty, Correct, Wrong, Test);           
        }
        // Function To Round Values From 5 Cards.
        public static void Round5(float Temp, float Number1, float Number2, float Number3, string Operator1, string Operator2, int Difficulty, int Correct, int Wrong, int Test)
        {
            double Round = Math.Round(Temp, 0, MidpointRounding.AwayFromZero);
            float Answer = Convert.ToSingle(Round);
            Guess.Guess5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
        }
    }
}