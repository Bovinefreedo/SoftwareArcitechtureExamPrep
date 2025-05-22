using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Reccursion
{
    public class Sudoku
    {
        public bool legalRow(int[,] sudoku, int row){
            return false;
        }

        public bool legalColumn(int[,] sudoku, int column)
        {
            return false;
        }

        public bool legalSquare(int[,] sudoku, int row, int column)
        {
            int squareRow = row / 3;
            int squareColumn = column / 3;
            return false;
        }

        public bool legalSudoku(int[,] sudoku) {

            for (int i = 0; i < 9; i++) {
                if (!legalRow(sudoku, i))
                {
                    return false;
                }
                if (!legalColumn(sudoku, i)) {
                    return false;
                }
            }
            for (int row = 0; row < 9; row += 3)
            {
                for (int column = 0; column < 9; column += 3)
                {
                    if (!legalSquare(sudoku, row, column))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool legalPlacement(int[,] sudoku, int row, int column, int num) { 
            for(int i = 0; i < 9; i++)
            {
                if (sudoku[row, i] == num || sudoku[i, column] == num)
                {
                    return false;
                }
            }
            for (int i = 0; i < 3; i++) { 
                for(int j = 0; j < 3; j++)
                {
                    if (sudoku[i + (row / 3) * 3, j + (column / 3) * 3] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void solveSquare(int[,] sudoku, int row, int column) { 
            
        }

        public void printSudoku(int[,] sudoku)
        {
            Console.WriteLine("-----------------------");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write($"| {sudoku[i, j]} ");
                }
                Console.WriteLine("|");
                Console.WriteLine("-----------------------");
            }
        }

    }
}
