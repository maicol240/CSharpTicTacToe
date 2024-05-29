namespace Tic_Tac_Toe
{
    /// <summary>
    /// Usefull Utilities like : Write Line with Color and displaying The Menu
    ///
    /// </summary>
    internal static class Helper
    {
        public static void WriteLine(string character, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(character);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Write(string character, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(character);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DisplayMenu()
        {
            Helper.WriteLine("0)Top Left\t1)Top Middle\t2)Top Right", ConsoleColor.Yellow);
            Helper.WriteLine("3)Center Left\t4)Center Middle\t5)Center Right", ConsoleColor.Yellow);
            Helper.WriteLine(
                "6)Bottom Left\t7)Bottom Middle\t8)Bottom Right\n",
                ConsoleColor.Yellow
            );
            Helper.Write("Choose a Tile:", ConsoleColor.Yellow);
        }
    }
}
