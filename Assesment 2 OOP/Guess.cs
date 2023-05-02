using System;

namespace Assesment2
{
    class Guess
    {
        public static void Guess3(float Answer, float Number1, float Number2, string Operator, int Difficulty, int Correct, int Wrong)
        {
            Console.WriteLine("\nSolve the following -\n" + Number1 + " " + Operator + " " + Number2 + " " + "\n(Rounded to the nearest whole number!)\n");
            float Guess = Convert.ToInt32(Console.ReadLine());
            Solve.Solving(Guess, Answer, Difficulty, Correct, Wrong);
        }
        public static void Guess5(float Answer, float Number1, float Number2, float Number3, string Operator1, string Operator2, int Difficulty, int Correct, int Wrong)
        {
            Console.WriteLine("\nSolve the following -\n" + Number1 + " " + Operator1 + " " + Number2 + " " + Operator2 + " " + Number3 + "\n(Rounded to the nearest whole number!)\n");
            float Guess = Convert.ToInt32(Console.ReadLine());
            Solve.Solving(Guess, Answer, Difficulty, Correct, Wrong);
        }
    }
}