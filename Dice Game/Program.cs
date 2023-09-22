using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int playerRandomNum;
            int AIRandomNum;

            int playerScore = 0;
            int AIscore = 0;

            string retry;


            Random r1 = new Random();

            do
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Press any key to roll the dice!");
                    Console.ReadKey();


                    playerRandomNum = r1.Next(1, 7);
                    Console.WriteLine("You Rolled a " + playerRandomNum);

                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(1000);

                    AIRandomNum = r1.Next(1, 7);
                    Console.WriteLine("The Ai Got :" + AIRandomNum);



                    if (playerRandomNum > AIRandomNum)
                    {
                        playerScore++;
                        Console.WriteLine("Player win this Rounds");
                    }
                    else if (playerRandomNum < AIRandomNum)

                    {
                        AIscore++;
                        Console.WriteLine("Ai Won this Round");
                    }
                    else
                    {
                        Console.WriteLine("DRAW :)");

                    }


                    Console.WriteLine("The SCORE IS NOW - PLAYER :" + playerScore + " - AI :" + AIscore + ".");
                    Console.WriteLine();
                  

                }

                if (playerScore > AIscore)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerScore < AIscore)
                {
                    Console.WriteLine("You Lose !");
                }
                else
                {
                    Console.WriteLine("DRAW!");
                }

                Console.WriteLine("if you want to do another operation Press (y/Y)");
                retry = Console.ReadLine();
                Console.Clear(); // Clear the console screen
            } while (retry == "Y" || retry == "y");



        }
    }
}
  