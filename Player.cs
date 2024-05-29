using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
	internal class Player
	{


		public string Name { get; set; }

		public char Icon { get; init; } 

		public Player(string name,char icon) {
		
		this.Name = name;
		this.Icon = icon;
		}



	}
}
