using Microsoft.Extensions.DependencyInjection;
using NoughtsAndCrosses.Interfaces;
using NoughtsAndCrosses.Services;
using System;

namespace NoughtsAndCrosses
{
    class Program
    {
        private static IServiceProvider _services;

        private static void Main(string[] args)
        {
            IGameBuilder builder = CreateGameBuilder();
            builder.AddPlayers();
            builder.Build().Run();
        }

        private static GameBuilder CreateGameBuilder()
        {
            return new GameBuilder();
        }

        public static IServiceProvider Services
        {
            get
            {
                if (_services != null) return _services;

                var services = new ServiceCollection();

                services.AddTransient<IGame, Game>();
                services.AddTransient<IGameRunner, GameRunner>();
                services.AddTransient<IGameBoardPrinter, GameBoardPrinter>();
                services.AddTransient<IOptionsSelector, OptionsSelector>();
                services.AddTransient<IConsole, ConsoleWrapper>();

                return _services = services.BuildServiceProvider();
            }
        }
    }
}
