using System;
using System.Data.Common;

namespace Takuzu 
{
    public static class Takuzu
    {
        public static void PrintGrid(int[,] grid)
        {
            //FIXME
            string board = "\n";
            string line;
            int lx = grid.GetLength(0);
            int ly = grid.GetLength(1);
            int el; //element dans le tableau
            for (int i = ly -1; i >= 0; i--)
            {
                board =  i + " "+ board;
            }
            board = "   " + board;
            for (int i = 0; i < lx; i++)
            {
                line = "\n";
                for (int j = ly -1; j >= 0; j--)
                {
                    el = grid[i, j];
                    if (el > 1 || el < 0)
                        line = " |" + line;
                    else
                        line = grid[i,j] + "|" + line;
                }
                line = i + " |" + line;
                board = board + line;
            }
            Console.WriteLine(board);
        }

        public static bool IsRowValid(int[,] grid, int row)
        {
            //FIXME
            int i = 0;
            int ly = grid.GetLength(1);
            while (i > ly && )
            {
                
            }
            return false;
        }
        
        public static bool IsColumnValid(int[,] grid, int col)
        {
            //FIXME
            return false;
        }

        public static bool IsGridValid(int[,] grid)
        {
            //FIXME
            return false;
        }

        public static bool PutCell(int[,] grid, int x, int y, int val)
        {
            //FIXME
            return false;
        }
        
        public static void Game(int[,] start)
        {
            //FIXME
        }

        public static int[,] AI(int[,] grid)
        {
            //FIXME
            return null;
        }
    }
}