using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Game
    {
        private AI ai = new AI();
        private int WinCondition;
        private int PlayerScore = 0;
        private int EnemyScore = 0;

        public Game(int wincondition)
        {
            this.WinCondition = wincondition;
        }

        public void run()
        {
            while (PlayerScore != WinCondition && EnemyScore != WinCondition)
            {
                Console.Clear();
                
                Console.WriteLine("--player score--");
                Console.WriteLine(PlayerScore);

                Console.WriteLine("--Enemy score--");
                Console.WriteLine(EnemyScore);

                Console.WriteLine();

                Console.WriteLine("--Win Condition--");
                Console.WriteLine(WinCondition);

                Console.WriteLine();

                Console.WriteLine("Input 1 for scissors");
                Console.WriteLine("Input 2 for paper");
                Console.WriteLine("Input 3 for rock");
                
                int input = Convert.ToInt32(Console.ReadLine());
                int EnemyInput = ai.MakeDecision();

                if (input == 1 && EnemyInput == 2 || input == 2 && EnemyInput == 3 || input == 3 && EnemyInput == 1)
                {
                    Console.WriteLine("Player wins one point");
                    ++PlayerScore;
                    Console.ReadLine();
                }
                else if (input == EnemyInput)
                {
                    Console.WriteLine("It's a tie!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enemy wins one point");
                    ++EnemyScore;
                    Console.ReadLine();
                }
            }

            if (PlayerScore == WinCondition)
            {
                Console.WriteLine("Congrats you win!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You lost...");
                Console.ReadLine();
            }
        }

    }
}
