using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Reccursion
{
    public class Queens
    {
        private int numberOfSolutions = 0;

        //This function checks if the placement of a queen is legal.
        public bool legalPlacement(string[,] board, int column, int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (board[column,row - i].Equals("Q"))
                        return false;
                    if (column - i >= 0 && board[column - i,row - i].Equals("Q"))
                        return false;
                    if (column + i < board.GetLength(0) && board[column + i,row - i].Equals("Q"))
                        return false;
                }
            }
            return true;
        }

        //this determins where we should attempt to place the next queen.
        //It also needs to determine if all the queens are placed, and count the number of solutions.
        public void placeQueen(string[,] board, int row)
        {
            if (row == board.GetLength(0))
            {
                numberOfSolutions++;
                printBoard(board);
                Console.ReadLine();
                Console.WriteLine("more solutions");
                return;
            }
            for (int column = 0; column < board.GetLength(0); column++)
            {
                if (legalPlacement(board, column, row))
                {
                    board[column,row] = "Q";
                    placeQueen(board, row + 1);
                    board[column,row] = "";
                }
            }
        }

        public int QueensN(int n)
        {
            numberOfSolutions = 0;
            string[,] board = new string[n,n];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = "";
                }
            }
            placeQueen(board, 0);
            return numberOfSolutions;
        }

        public void printBoard(string[,] board)
        {
            for (int k = 0; k < board.GetLength(0); k++)
            {
                Console.Write("----");
            }
            Console.WriteLine();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (board[j,i].Equals("Q"))
                        Console.Write("| Q ");
                    else
                        Console.Write("|   ");
                }
                Console.WriteLine("|");
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write("----");
                }
                Console.WriteLine();
            }
        }
    }
}
