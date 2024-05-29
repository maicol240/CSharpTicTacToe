namespace Tic_Tac_Toe
{
    internal class Player
    {
        public string? Name { get; set; }

        public char Icon { get; init; }

        public Player(char icon)
        {
            this.Icon = icon;
        }
    }
}
