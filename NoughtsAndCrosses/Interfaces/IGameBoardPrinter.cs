namespace NoughtsAndCrosses.Interfaces
{
    public interface IGameBoardPrinter
    {
        void PrintBoard();
        void ProcessSelection(Player player, int squareIndex);
        void PrintOptions();
    }
}