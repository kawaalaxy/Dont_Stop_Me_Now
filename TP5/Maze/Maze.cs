using System;
using System.IO;
namespace Maze
{
	internal static class Maze
	{
		/// <summary>
		/// MAZE:
		/// <para/>
		/// This is where you should call your functions to make your program work.
		/// </summary>
		/// <param name="args">unused</param>
		public static void Main(string[] args)
		{
			// get .maze filename
			// get .solved filename
			// parse .maze file
			// print the maze (BONUS)
			// solve the maze
			// print the maze (BONUS)
			// save solution in .solved file
			//Console.WriteLine(GetOutputFile("../../../tests/map1.maze"));
			//ParseFile("../../../tests/map3.maze");
			char[][] maze =
			{
				new char[] {'O', 'O', 'O', 'B'},
				new char[] {'O', 'O', 'O', 'O'},
				new char[] {'B', 'O', 'O', 'S'}
			};
			Console.WriteLine(FindStart(maze).X + "," + FindStart(maze).Y);
			
			grid_to_str(ParseFile("../../../tests/map2.maze"));
			
			


		}
		
		
		private static string AskMazeFile()
		{
			Console.WriteLine("Which file should be loaded ?");
			string map = Console.ReadLine(); //"../../../tests/map1.maze"

			while (!File.Exists(map) && Path.GetExtension(map) != ".maze")
			{
				Console.WriteLine("Which file should be loaded ?");
				map = Console.ReadLine();
			}
			Console.WriteLine("Thank you, bye");
			return map;
		}

		private static string GetOutputFile(string fileIn)
		{
			return Path.ChangeExtension(fileIn, "solved");
		}

		private static char[][] ParseFile(string file)
		{
			string [] str_list = File.ReadAllLines(file);
			int str_length = str_list.Length;				//longueur de la liste de string
			char[] char_list = new char[str_list[0].Length];//longueur de la liste de caracteres a retourner
			int str_length2;
			char[][] mapup = new char[str_length][];		//longueur de la liste de listes de caracteres
			
			for (int i = 0; i < str_length; i++)
			{
				str_length2 = str_list[i].Length;			//longueur de la string
				for (int j = 0; j < str_length2; j++)
				{
					char_list[j] = str_list[i][j];
				}

				mapup[i] = char_list;
			}
			return mapup;
		}

		private static void grid_to_str(char[][] grid)
		{
			string str = "";
			int test = grid[0].Length - 1;
			for (int j = 0; j < grid.Length-1; j++)
			{
				for (int i = 0; i < grid[0].Length-1; i++)
				{
					str += grid[j][i];
				}
			}
			Console.WriteLine(str);
		}

		private static Point FindStart(char[][] grid)
		{
			int ix = 0;
			int iy = 0;
			int ly = grid.Length;
			int lx = grid[0].Length;
			while (iy < ly)
			{
				while (ix < lx)
				{
					if (grid[iy][ix] == 'S')
						return new Point(ix,iy);
					++ix;
					
				}
				ix = 0;
				++iy;
			}
			throw new Exception(" Start not found");

		}

		private static bool SolveMazeBackTracking(char[][] grid, int[][] processed, Point p)
		{
			if (p.Y >= grid.Length || p.X >= grid[0].Length)
				return false;
			
			if (processed[p.Y][p.X] != 0)
				return false;
			
			processed[p.Y][p.Y] = 1;
			
			if (grid[p.Y][p.X] == 'S')
				return true;
			
			if (grid[p.Y][p.X] == 'B')
				return false;
			
			if (SolveMazeBackTracking(grid, processed, new Point((p.Y) + 1, p.X)))
			{
				grid[p.Y][p.X] = 'P';
				return true;
			}
			if (SolveMazeBackTracking(grid, processed, new Point(p.Y, (p.Y) - 1)))
			{
				grid[p.Y][p.X] = 'P';
				return true;
			}
			if (SolveMazeBackTracking(grid, processed, new Point(p.Y, (p.Y) + 1)))
			{
				grid[p.Y][p.X] = 'P';
				return true;
			}
			if (SolveMazeBackTracking(grid, processed, new Point((p.Y) - 1, p.X)))
			{
				grid[p.Y][p.X] = 'P';
				return true;
			}
			return false;
		}

		private static void SaveSolution(char[][] grid, string fileOut)
		{
			int lx = grid[0].Length;
			int [][] processed = new int[grid.Length][];
			//GetOutputFile(SolveMazeBackTracking(grid, 
		}
		


	}

	/// <summary>
	///   Class that allows to store 2D coordinates.
	/// </summary>
	internal class Point
	{
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int Y { get; set; }
		public int X { get; set; }
	}
	
}