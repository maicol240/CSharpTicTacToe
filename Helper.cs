using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
	/// <summary>
	/// Usefull Utilities like : Write Line with Color and displaying The Menu
	/// 
	/// </summary>
	internal static class Helper
	{


	
		public static void WriteLine(string character,ConsoleColor color)
		{
			Console.ForegroundColor = color;
            Console.WriteLine(character);
			Console.ForegroundColor=ConsoleColor.White;


        }

		public static void Write(string character, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(character);
			Console.ForegroundColor = ConsoleColor.White;


		}






	}
}
