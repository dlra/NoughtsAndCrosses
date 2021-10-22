namespace NoughtsAndCrosses.Interfaces
{
    public interface IGameRunner
    {
        bool IsGameOver { get; }

        void ProcessTurn();
    }
}