using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Welcome to this Dice Game!");

            int numberOfBot;
            int numberOfUser;
            int dice = rnd.Next(1, 7);
            int scoreBot = 0, scoreUser = 0;
            bool bo = true;
            
            
            while (bo)
            {
                Console.WriteLine("Choose an number: ");
                numberOfUser = Convert.ToInt32(Console.ReadLine());

                numberOfBot = dice;

                if(numberOfUser > numberOfBot)
                {
                    scoreUser++;
                    Console.WriteLine("User wins this round and have score " + scoreUser);
                    Console.WriteLine("Bot have score " + scoreBot);
                    
                }
                else if(numberOfUser < numberOfBot)
                {
                    scoreBot++;
                    Console.WriteLine("Bot wins this round and have score " + scoreBot);
                    Console.WriteLine("User have score " + scoreUser);
                    
                }
                else
                {
                    Console.WriteLine("Draw!");
                    Console.WriteLine("Play again!");
                }

                if (scoreUser == 10)
                {
                    Console.WriteLine("Player Won!");
                    bo = false;
                    
                }
                else if (scoreBot == 10)
                {
                    Console.WriteLine("Bot Won!");
                    bo = false;
                }

            }
            



        }
    }
}
