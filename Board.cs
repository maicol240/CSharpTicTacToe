using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{

	
	static class Board
	{
		public static char[] boardTiles = {' ',' ',' ',' ' ,' ',' ',' ', ' ',' ' };



		public static void DrawBoard()
		{

			Console.WriteLine($" {boardTiles[0]} "+"| " + $" {boardTiles[1]} " + " | " + $"{boardTiles[2]}");
			Console.WriteLine("___|_____|___");
			Console.WriteLine($" {boardTiles[3]} " + "| " + $" {boardTiles[4]} " + " | " + $"{boardTiles[5]}");
			Console.WriteLine("___|_____|___");
			Console.WriteLine($" {boardTiles[6]} " + "| " + $" {boardTiles[7]} " + " | " + $"{boardTiles[8]}");
			Console.WriteLine($"   " + "| " + $"   " + " | " + $"   ");
		}













	}
}
