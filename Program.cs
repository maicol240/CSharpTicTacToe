using Tic_Tac_Toe;


do
{
	Helper.WriteLine("Welcome Players", ConsoleColor.Yellow);

	Helper.Write("Player X: Write Your Name: ", ConsoleColor.Red);

	string? playerX = Console.ReadLine();

	Helper.Write("Player O: Write Your Name: ", ConsoleColor.Blue);

	string? playerO = Console.ReadLine();


	Game game = new Game(playerX, playerO);

	Console.WriteLine();

	game.StartGame();


	Console.WriteLine("Press 1 exit  or anykey to play another Round");
	string choice= Console.ReadLine();
	if(choice == "1")
	{
			break;
	}

	Console.Clear();

}while (true);

