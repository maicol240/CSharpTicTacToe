namespace Tic_Tac_Toe
{
    public class Board
    {
        public  char[] boardTiles = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        public void DrawBoard()
        {
            Console.WriteLine(
                $" {boardTiles[0]} " + "| " + $" {boardTiles[1]} " + " | " + $"{boardTiles[2]}"
            );
            Console.WriteLine("___|_____|___");
            Console.WriteLine(
                $" {boardTiles[3]} " + "| " + $" {boardTiles[4]} " + " | " + $"{boardTiles[5]}"
            );
            Console.WriteLine("___|_____|___");
            Console.WriteLine(
                $" {boardTiles[6]} " + "| " + $" {boardTiles[7]} " + " | " + $"{boardTiles[8]}"
            );
            Console.WriteLine($"   " + "| " + $"   " + " | " + $"   \n");
        }

        public bool IsPlayableTile(int tile)
        {
            if (boardTiles[tile] == ' ')
            {
                return true;
            }
            else
                return false;
        }
    }
}
