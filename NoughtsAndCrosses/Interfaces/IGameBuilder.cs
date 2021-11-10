namespace NoughtsAndCrosses.Interfaces
{
    public interface IGameBuilder
    {
        IGameBuilder AddPlayers();
        IGame Build();
    }
}