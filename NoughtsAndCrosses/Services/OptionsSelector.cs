using NoughtsAndCrosses.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NoughtsAndCrosses.Services
{
    public class OptionsSelector : IOptionsSelector
    {
        private readonly IConsole _console;
        private readonly List<int> _allOptions = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public OptionsSelector(IConsole console)
        {
            _console = console;
        }

        public int SelectOption(Dictionary<int, Player> previousSelections, Player player)
        {
            int selection = -1;
            bool isSelected = false;
            var allowedSelections = _allOptions.Except(previousSelections.Keys);
            // player given choice of options
            _console.WriteLine($"{player.Name}, which square would you like to play?");
            
            while (!isSelected)
            {
                var selectionString = _console.ReadLine();
                // player has to check a correct option
                selection = int.Parse(selectionString);

                if (!allowedSelections.Contains(selection))
                {
                    _console.WriteLine("This is not a valid selection. Please choose a valid selection");
                    continue;
                }

                isSelected = true;
            }

            return selection;
        }
    }
}