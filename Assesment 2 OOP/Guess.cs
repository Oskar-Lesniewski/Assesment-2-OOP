using System;

namespace Assesment2
{
    // Class That Is Called For Users To Guess.
    class Guess
    {
        // Guess Method For 3 Cards.
        public static void Guess3(float Answer, float Number1, float Number2, string Operator, int Difficulty, int Correct, int Wrong, int Test)
        {
            var Sum = "\nSolve the following -\n" + Number1 + " " + Operator + " " + Number2 + " " + "\n(Rounded to the nearest whole number!)\n";
            if (Test == 0)
            {
                Console.WriteLine(Sum);
                while (true)
                {
                    float Guess = Convert.ToInt32(Console.ReadLine());
                    if (float.IsNaN(Guess) == false)
                    {
                        Solve.Solving(Guess, Answer, Difficulty, Correct, Wrong, Test);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again.");
                        continue;
                    }
                    break;
                }            
            }          
            else if (Test == 1)
            {
                Sum = Number1 + " " + Operator + " " + Number2 + " = ";
                Testing.Display(Answer, Sum);
            }
        }
        // Guess Method For 5 Cards.
        public static void Guess5(float Answer, float Number1, float Number2, float Number3, string Operator1, string Operator2, int Difficulty, int Correct, int Wrong, int Test)
        {
            var Sum = "\nSolve the following -\n" + Number1 + " " + Operator1 + " " + Number2 + " " + Operator2 + " " + Number3 + "\n(Rounded to the nearest whole number!)\n";
            if (Test == 0)
            {
                Console.WriteLine(Sum);
                float Guess = Convert.ToInt32(Console.ReadLine());
                Solve.Solving(Guess, Answer, Difficulty, Correct, Wrong, Test);
            }
            if (Test == 1)
            {
                Sum = Number1 + " " + Operator1 + " " + Number2 + " " + Operator2 + " " + Number3 + " = ";
                Testing.Display(Answer, Sum);
            }
        }
    }
}