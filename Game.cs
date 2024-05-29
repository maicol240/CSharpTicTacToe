using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
	internal class Game
	{
		public Player PlayerX { get; set; } = new Player('X');
		public Player PlayerO { get; set; } = new Player('O');
		private Board  Board { get; set; }



		public Game(string player1, string player2)
		{

			///Check If Names Are Empty
			if(player1== null || string.IsNullOrEmpty(player1))
			{
				this.PlayerX.Name = "Player1";

			}
			else if(player2== null || string.IsNullOrEmpty(player2))
			{
				this.PlayerO.Name = "Player2";
			}

			else
			{
				this.PlayerX.Name = player1;
				this.PlayerO.Name = player2;

			}

			

		}

		public void StartGame() 
		
		{
            
            Board.DrawBoard();
			
		
		}





	}
}
