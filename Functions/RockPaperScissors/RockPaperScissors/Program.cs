using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesAnount = 5;
            Console.WriteLine("Enter gamse amount: ");
            Console.Write("");
            gamesAnount = int.Parse(Console.ReadLine());

            StartGame(gamesAnount);
        }

        static void StartGame(int gamesAnount)
        {
            int playerChoice = 0, computerChoice = 0;
            int computerWins = 0, playerWins = 0;

            for (int i = 0; i < gamesAnount; i++)
            {
                MakeMove(ref playerChoice, ref computerChoice);
                CheckWinner(playerChoice, computerChoice, ref computerWins, ref playerWins);
            }

            PrintResult(computerWins, playerWins);
        }

        static void CheckWinner(int playerChoice, int computerChoice, ref int computerWins, ref int playerWins)
        {
            if ((playerChoice == 1 && computerChoice == 3)
              || (playerChoice == 2 && computerChoice == 1)
              || (playerChoice == 3 && computerChoice == 2))
            {
                playerWins++;
                Console.WriteLine("Player wins");
            }
            else if (playerChoice == computerChoice)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                computerWins++;
                Console.WriteLine("Computer wins");
            }
        }

        static void PrintResult(int computerWins, int playerWins)
        {
            if (computerWins > playerWins)
            {
                Console.WriteLine("\nComputer won");
            }
            else if (playerWins > computerWins)
            {
                Console.WriteLine("\nPlayer won");
            }
            else
            {
                Console.WriteLine("\nDraw");
            }
        }

        static void MakeMove(ref int playerChoice, ref int computerChoice)
        {
            var rnd = new Random();

            do
            {
                Console.WriteLine("1: Scissors\n2:Rock\n3:3:Paper");

                playerChoice = int.Parse(Console.ReadLine());
            }
            while (playerChoice < 1 || playerChoice > 3);

            computerChoice = rnd.Next() % 3 + 1;
        }
    }
}
