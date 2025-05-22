using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Reccursion
{
    public class Sudoku
    {
        int[,] sudoku = new int[9, 9] {
            { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6 ,0 ,0 ,0 ,2 ,8 ,0 ,0 },
            { 0 ,0 ,4 ,1 ,9 ,5 ,0 ,0 ,8 },
            { 9 ,8 ,7 ,4 ,3 ,6 ,2 ,1 ,5 }
        };

        public bool legalRow(int row){
            return false;
        }

        public bool legalColumn(int column)
        {
            return false;
        }

        public bool legalSquare(int row, int column)
        {
            int squareRow = row / 3;
            int squareColumn = column / 3;
            return false;
        }

        public bool legalSudoku() {

            for (int i = 0; i < 9; i++) {
                if (!legalRow(i))
                {
                    return false;
                }
                if (!legalColumn(i)) {
                    return false;
                }
            }
            for (int row = 0; row < 9; row += 3)
            {
                for (int column = 0; column < 9; column += 3)
                {
                    if (!legalSquare(row, column))
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

        public void solve(int row, int column) { 
            
        }

        public void printSudoku()
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
