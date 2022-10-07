using System;
namespace TheBettingGame
{
    class program
    {
        static void Main(String[] args)
        {
            double odds = .75;
            Random random = new Random();
            Guy player = new Guy() { Cash = 100, Name = "The player" };
            Console.WriteLine("welcome to the betting game. The odds are " + odds);
            while(player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if(int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if(random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("you win " + winnings);
                            player.Receivecash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("Badluck try next time");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("please enter a valid number");
                }
            }
            Console.WriteLine("the house always wins");
        }
        
    }
}