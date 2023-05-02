using System;

namespace Assesment2
{
    // Testing class, prints out the pack after each manipulation to make sure everything is working
    public class Testing
    {
        public static void mainTest()
        {
            Pack pack = new Pack();
            Console.WriteLine("Initial pack:");
            foreach (Card card in pack.pack)
            {
                Console.WriteLine(card.Display());
            }          
            while (true)
            {
                Console.WriteLine("Type in 1 for a Fisher-Yates Shuffle, 2 to Riffle Shuffle, and 3 for No Shuffle.");
                try
                {
                    int shuffle = Convert.ToInt32(Console.ReadLine());
                    if (shuffle < 1 || shuffle > 3)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                break;
            }
            Console.WriteLine("Press Enter to exit test.");
            Console.ReadLine();
        }
    }
                
}
