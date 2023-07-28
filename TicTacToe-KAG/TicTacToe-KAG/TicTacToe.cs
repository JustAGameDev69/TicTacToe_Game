using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Game
{
    class TicTacToe
    {
        //Khoi tao
        public TicTacToe()
        {
            play();
        }

        //Luot choi
        public void play()
        {
            int moveCounter = 0;
            Board gameBoard = new Board();

            Player playerX = new Player('X');
            Player playerO = new Player('O');

            Player currentPlayer = playerX;

            bool play = true;
            while (play)
            {
                gameBoard.printBoard();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                try
                {
                    gameBoard.putMark(currentPlayer, playerX.takeTurn());
                    gameBoard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameBoard))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                        gameBoard.printBoard();
                        play = false;
                    }
                    else if (checkDraw(moveCounter))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DRAW");
                        gameBoard.printBoard();
                        play = false;
                    }
                    currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }
    }
}