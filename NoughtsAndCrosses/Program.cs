using NoughtsAndCrosses.Services;
using System;

namespace NoughtsAndCrosses
{
    class Program
    {
        private static void Main(string[] args)
        {
            CreateGameBuilder().Build().Run();
        }

        private static GameBuilder CreateGameBuilder()
        {
            return new GameBuilder();
        }
    }
}
