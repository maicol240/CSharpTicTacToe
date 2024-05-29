using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
	internal class Game
	{
		public Player PlayerX { get; set; } 
		public Player PlayerO { get; set; }
		private Board  Board { get; set; }



		public Game(Player player1, Player player2)
		{
			this.PlayerX = player1;
			this.PlayerO = player2;


		}






	}
}
