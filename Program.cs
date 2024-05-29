using Tic_Tac_Toe;


//Welcome And Player Selection
Helper.WriteLine("Welcome Players",ConsoleColor.Yellow);

Helper.Write("Player X: Write Your Name: ",ConsoleColor.Red);

string? playerX=Console.ReadLine();

Helper.Write("Player O: Write Your Name: ", ConsoleColor.Blue);

string? playerO = Console.ReadLine();

//Create Game
Game game=new Game(playerX,playerO);

Console.WriteLine(game.PlayerX.Name); 




