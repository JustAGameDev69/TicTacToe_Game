using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Game
{
    class Program
    {


        static void Main(string[] args)
        {
            StartMenu();
            TicTacToe game = new TicTacToe();
            game.play();
            Console.ReadKey();
        }

        public static void StartMenu()
        {
            bool PvP, PvA, AvA = false;
            int choice = 0;

            while (choice < 1 || choice > 3)
            {
                Console.WriteLine("This is TicTacToe Game on Console C#!");
                Console.WriteLine("Game mode: (Enter number to choose!)");
                Console.WriteLine("1. Player vs Player");
                Console.WriteLine("2. Player vs A.I");
                Console.WriteLine("3. A.I vs A.I");
                Console.WriteLine("4. Quit Game!");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }

                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }
            }

            Console.WriteLine($"You chose option {choice}.");

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }

    }
}