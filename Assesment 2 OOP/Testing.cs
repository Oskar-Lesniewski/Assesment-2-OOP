using System;

namespace Assesment2
{
    // Testing Class, Shows The Maths Works As Intended And Uses BIDMAS.
    class Testing
    {
        public static void mainTest(int Test)
        {
            // While Loop To Handle Errors.
            while (true)
            {
                Console.WriteLine("\nTESTING\n\nPRESS 1 FOR TESTING OF 3 CARDS DEAL\nPRESS 2 FOR TESTING OF 5 CARDS DEAL\nPRESS 3 TO GO BACK TO MENU\n");
                try
                {
                    int Testing = Convert.ToInt32(Console.ReadLine());
                    if (Testing < 1 || Testing > 3)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        // Testing That The Answers For 3 Cards Dealt Are Correct.
                        if (Testing == 1)
                        {
                            Console.WriteLine("The Answers Using BIDMAS Should Be As Follows, 22, -2, 120, 1");
                            Conversion.Conversion3("Diamonds", 10, 12, 3, 0, 0, Test);
                            Conversion.Conversion3("Clubs", 10, 12, 3, 0, 0, Test);
                            Conversion.Conversion3("Hearts", 10, 12, 3, 0, 0, Test);
                            Conversion.Conversion3("Spades", 10, 12, 3, 0, 0, Test);
                            Console.WriteLine("TEST COMPLETE FOR 3 CARDS");
                            mainTest(1);
                        }
                        // Testing That The Answers For 5 Cards Dealt Are Correct.
                        if (Testing == 2)
                        {
                            Console.WriteLine("\nThe Answers Using BIDMAS Should Be As Follows, 35, 9, 166, 11");
                            Conversion.Conversion5("Diamonds", "Diamonds", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Diamonds", "Clubs", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Diamonds", "Hearts", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Diamonds", "Spades", 10, 12, 13, 5, 0, 0, Test);
                            Console.WriteLine("\nThe Answers Using BIDMAS Should Be As Follows, 11, -15, -146, 9");
                            Conversion.Conversion5("Clubs", "Diamonds", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Clubs", "Clubs", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Clubs", "Hearts", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Clubs", "Spades", 10, 12, 13, 5, 0, 0, Test);
                            Console.WriteLine("\nThe Answers Using BIDMAS Should Be As Follows, 133, 107, 1560, 9");
                            Conversion.Conversion5("Hearts", "Diamonds", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Hearts", "Clubs", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Hearts", "Hearts", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Hearts", "Spades", 10, 12, 13, 5, 0, 0, Test);
                            Console.WriteLine("\nThe Answers Using BIDMAS Should Be As Follows, 14, -12, 11, 0");
                            Conversion.Conversion5("Spades", "Diamonds", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Spades", "Clubs", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Spades", "Hearts", 10, 12, 13, 5, 0, 0, Test);
                            Conversion.Conversion5("Spades", "Spades", 10, 12, 13, 5, 0, 0, Test);
                            Console.WriteLine("TEST COMPLETE FOR 5 CARDS");
                            mainTest(1);
                        }
                        // Return To Menu.
                        if (Testing == 3)
                        {
                            Tutorial.Menu();
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
        // Solving Part Of Testing.
        internal static void Display(float Answer, string Sum)
        {
            Console.WriteLine(Sum + Answer);
        }
    }
}

