using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, please enter your name:");
            int playerScore = 0;
            string playerName = "";
            playerName = Console.ReadLine();

            int add = 0;
            while (playerScore < 10)
            {
                Console.Write("Increment Score :");
                add = Convert.ToInt32(Console.ReadLine());
                playerScore = playerScore + add;
            }

            Console.Write("Score of " + playerName);
            Console.Write("\n");
            Console.Write(playerScore);
            Console.ReadLine();
        }
    }
}
