using System;
using System.IO;

namespace Assesment2
{
    class Solve
    {
        public static void Solving(float Guess, float Answer, int Difficulty, int Correct, int Wrong)
        {
            if (Guess == Answer)
            {
                Correct += 1;
                Console.WriteLine("\nThats Correct!\n");
            }
            else
            {
                Wrong += 1;
                Console.WriteLine("\nThats Not Right, Try A New One!\n");
                Console.WriteLine("The Answer Was " + Answer);
            }
            Continue(Difficulty, Wrong, Correct);
        }

        private static void Continue(int Difficulty, int Correct, int Wrong)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Would you like to do another problem?\n1. Yes\n2. Back To Menu\n");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if (amount < 1 || amount > 2)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if (amount == 1)
                        {
                            Pack.shuffleCardPack(Difficulty, Correct, Wrong);
                        }
                        if (amount == 2)
                        {
                            File.WriteAllText("Statistics.txt", "\nYou Got " + Convert.ToString(Correct) + " Correct Last Session!" + "\nYou Got " + Convert.ToString(Wrong) + " Wrong Last Session!");
                            Tutorial.Menu();
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                break;
            }
        }

            // Error handling to make sure the user selects the right amount of extra cards they want dealt
            
        
    }
}