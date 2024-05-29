using System.Diagnostics.Metrics;

namespace Tic_Tac_Toe
{
    internal class Game
    {
        public Player PlayerX { get; set; } = new Player('X');
        public Player PlayerO { get; set; } = new Player('O');
		private Board Board = new Board();

		public Game(string player1, string player2)
        {
            ///Check If Names Are Empty
            if (player1 == null || string.IsNullOrEmpty(player1))
            {
                this.PlayerX.Name = "Player1";
            }
            else if (player2 == null || string.IsNullOrEmpty(player2))
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

            Player currentPlayer = this.PlayerX;
            ConsoleColor color = ConsoleColor.Red;
            int counter = 0;
            //Loop Until  A winner or draw
            do
            {
                Helper.WriteLine(
                    $"Player {currentPlayer.Icon}({currentPlayer.Name}) Turn",
                    color
                );

                Console.WriteLine();
                Board.DrawBoard();
                Helper.DisplayMenu();

                string choice;
                //validates the choice
                while (true)
                {
                    choice = Console.ReadLine();
                    Console.WriteLine();
                    bool isValid = IsValidInput(choice);

                    if (isValid)
                    {

                        Board.boardTiles[Convert.ToInt32(choice)]=currentPlayer.Icon;
                       
                        Console.Clear();

                        break;
                    }
					Helper.Write("Choose a Tile:", ConsoleColor.Yellow);
				}

                //checks for a winner
                bool gameResults= GameResult(currentPlayer);
                if (gameResults == true)
                {
                    Helper.WriteLine($"{currentPlayer.Name}: Wins!",color);
                    break;
                }

                //switch Player
                if (currentPlayer == this.PlayerX)
                {
                    currentPlayer = this.PlayerO;
                    color = ConsoleColor.Blue;
                }
                else
                {
                    color = ConsoleColor.Red;
					currentPlayer = this.PlayerX;

				}
                    
                
                counter++;

                if (counter == 9)
                {
                    Console.WriteLine("Is a Draw");
                }



            } while (counter<9);
        }

        /// validate if my input is in range,the tile is empty and is a number
        public bool IsValidInput(string input)
        {
            do
            {
                if (int.TryParse(input, out int result))
                {
                    if (result > 8 || result < 0)
                    {
                        Helper.WriteLine(
                            "I only know How to Count from 0 to 8\n",
                            ConsoleColor.DarkYellow
                        );
						
						return false;
                    }
                    else if (Board.IsPlayableTile(result))
                    {
                        
                        return true;
                    }
                    else
                    {
                        Helper.WriteLine(
                            "That tile is already occupied :(\n",
                            ConsoleColor.DarkYellow
                        );
						
						return false;
                    }
                }
                else
                {
                    Helper.WriteLine("I Cant Read Letters\n", ConsoleColor.DarkYellow);
					
					return false;
                }
            } while (true);
        }
        public bool GameResult(Player player)
        {
            //check Rows
            for(int i=0;i<3;i++)
            {
                int startingIndex = i*3;

				if (Board.boardTiles[startingIndex] == player.Icon && Board.boardTiles[startingIndex+1] == player.Icon && Board.boardTiles[startingIndex +2] == player.Icon)
				{

                    return true;


				}



			}

            //check Colums
            for(int i = 0; i < 3; i++)
            {


                if (Board.boardTiles[i]==player.Icon&& Board.boardTiles[i + 3] ==player.Icon && Board.boardTiles[i+6]==player.Icon)
                {
                    return true;
                }
            }

            //Check Diagonals
			if (Board.boardTiles[0] == player.Icon && Board.boardTiles[4] == player.Icon && Board.boardTiles[8] == player.Icon)
			{
				return true;
			}
            if (Board.boardTiles[2] == player.Icon && Board.boardTiles[4] == player.Icon && Board.boardTiles[6] == player.Icon)
            {
                return true;
            }

            else
                return false;



		}
    }
}
