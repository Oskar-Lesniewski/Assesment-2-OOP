using System;

namespace Assesment2
{
    internal class Round
    {
        public static void Round3(float Temp, float Number1, float Number2, string Operator, int Difficulty, int Correct, int Wrong)
        {
            double Round = Math.Round(Temp, 0, MidpointRounding.AwayFromZero);
            float Answer = Convert.ToSingle(Round);
            Guess.Guess3(Answer, Number1, Number2, Operator, Difficulty, Correct, Wrong);
        }
        public static void Round5(float Temp, float Number1, float Number2, float Number3, string Operator1, string Operator2, int Difficulty, int Correct, int Wrong)
        {
            double Round = Math.Round(Temp, 0, MidpointRounding.AwayFromZero);
            float Answer = Convert.ToSingle(Round);
            Guess.Guess5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong);
        }
    }
}