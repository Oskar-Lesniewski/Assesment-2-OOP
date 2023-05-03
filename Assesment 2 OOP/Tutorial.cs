using System;
using System.IO;

namespace Assesment2
{
    // Class That Houses The Tutorial.
    class Tutorial
    {
        private static void Main(string[] args)
        {
            Menu();
        }
        // Menu Where User Select What They Want To Do.
        public static void Menu()
        {
            // While Loop To Handle Errors.          
            while (true)
            {
                // What Is Wanted From The Application The User Chooses.
                Console.WriteLine("\nWelcome to the MathsTutor Application!\n\nWhat would you like to do today?\n1. Instructions\n2. Deal 3 Cards (2 Numbers and 1 Operator)\n3. Deal 5 Cards (3 Numbers and 2 Operators)\n4. Previous Sessions Stats. (Wipe after you Quit!)\n5. Quit\n6. Testing\n");
                try
                {
                    int Selection = Convert.ToInt32(Console.ReadLine());
                    if (Selection < 1 || Selection > 6)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        // Instructions Are Shown To User.
                        if (Selection == 1)
                        {
                            Console.WriteLine("1. How to Play -\nIn this Tutorial Program, you will be dealt cards that have been shuffled.\nThese cards each have set values.\nFor 3 Cards dealt, you will be given 3 different cards, the 1st and 3rd Cards are taken by value and serve as numbers.\nYou will do a maths sum with them, and the Operator is decided by the suit of the second card.\nThese will be converted and displayed for you so you can complete the maths sum.\nThe 5 cards dealt will work exactly the same just with an extra operator and number involved.\n\n2. Checking Stats -\n You can check the statistics for your previous session only! So make sure you check them if you are interested.\n\n3. Have Fun! -\n This is just practice and you will get better as you do more problems! (Tip: Don't forget BIDMAS).");
                            System.Threading.Thread.Sleep(2000);
                            Menu();
                        }
                        // 3 Cards Are Dealt.
                        if (Selection == 2)
                        {
                            int Correct = 0;
                            int Wrong = 0;
                            int Test = 0;
                            Console.WriteLine("\nShuffling the deck...\n");
                            Pack.shuffleCardPack(3, Correct, Wrong, Test);
                        }
                        // 5 Cards Are Dealt.
                        if (Selection == 3)
                        {
                            int Correct = 0;
                            int Wrong = 0;
                            int Test = 0;
                            Console.WriteLine("\nShuffling the deck...\n");
                            Pack.shuffleCardPack(5, Correct, Wrong, Test);
                        }
                        // Stats Are Shown.
                        if (Selection == 4)
                        {
                            string[] Stats = File.ReadAllLines("Statistics.txt");
                            foreach (string line in Stats)
                            {
                                Console.WriteLine(line);
                            }
                            Menu();
                        }
                        // User Can Quit.
                        if (Selection == 5)
                        {
                            Console.WriteLine("\nGoodbye, hope to see you soon!\n");
                            File.WriteAllText("Statistics.txt", String.Empty);
                            System.Threading.Thread.Sleep(2000);
                            Environment.Exit(0);
                        }
                        // Entering Test Mode.
                        if (Selection == 6)
                        {
                            int Test = 1;
                            Testing.mainTest(Test);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("\nInvalid input try again.\n");
                    continue;
                }
                break;
            }
        }
    }
}

