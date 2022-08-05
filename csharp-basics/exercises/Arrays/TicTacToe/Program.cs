using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char player = 'X';
        private static char winner = ' ';

        private static void Main()
        {
            PlayGame();
        }

        private static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("   0   1   2 ");
            Console.WriteLine($"0  {board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"1  {board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"2  {board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
        }

        private static void InitiateBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    board[r, c] = ' ';
                }
            }
        }

        private static void SwitchTurn()
        {
            player = player == 'X' ? player = 'O' : player = 'X';
        }

        private static bool IsBoardFilled()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    if(board[r, c] == ' ')
                    {
                        return false;
                    }                    
                }
            }

            return true;
        }

        private static void PlayGame()
        {
            InitiateBoard();
            DisplayBoard();

            while (!IsBoardFilled())
            {
                Console.WriteLine($"\n{player}'s turn. Add cell coordiantes in the following format: 0.0");
                string cell = Console.ReadLine();
                int row = (int)Char.GetNumericValue(cell, 0);
                int col = (int)Char.GetNumericValue(cell, 2);

                while (board[row, col] != ' ')
                {
                    Console.WriteLine("The cell is taken. Try an empty cell!");
                    cell = Console.ReadLine();
                    row = (int)Char.GetNumericValue(cell, 0);
                    col = (int)Char.GetNumericValue(cell, 2);
                }

                board[row, col] = player;

                DisplayBoard();                
                SwitchTurn();
                GetWinner();
                IsTie();
            }
        }

        private static void GetWinner()
        {
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
            {
                winner = board[0, 0];
            }
            else if ((board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2]))
            {
                winner = board[1, 0];
            }
            else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
            {
                winner = board[2, 0];
            }
            else if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0])
            {
                winner = board[0, 0];
            }
            else if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1])
            {
                winner = board[0, 1];
            }
            else if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2])
            {
                winner = board[0, 2];
            }
            else if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                winner = board[0, 0];
            }
            else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            {
                winner = board[0, 2];
            }
            else
            {
                winner = ' ';
            } 
        }

        private static void IsTie()
        {
            if (IsBoardFilled() && winner == ' ')
            {
                Console.WriteLine("\nThe game is a tie!");
                PlayAgain();
            }
            else if (!(winner == ' '))
            {
                Console.WriteLine($"\n{winner} wins!");
                PlayAgain();
            }
        }

        private static void PlayAgain()
        {
            player = 'X';
            winner = ' ';

            Console.WriteLine("\nWanna continue? Type YES or NO:");
            string choice = Console.ReadLine();
            choice = choice.ToUpper();

            if (choice == "YES")
            {
                PlayGame();
            }
            else if (choice == "NO")
            {
                Console.WriteLine("\nYou exited the game.");
                Environment.Exit(0);
            }
        }
    }
}