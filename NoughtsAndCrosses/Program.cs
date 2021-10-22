using System;

namespace NoughtsAndCrosses
{
    class Program
    {
        private static void Main(string[] args)
        {
            CreateGameRunner().Run();
        }

        private static GameRunner CreateGameRunner()
        {
            return new GameRunner();
        }
    }
}
