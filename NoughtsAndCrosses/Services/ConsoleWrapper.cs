using NoughtsAndCrosses.Interfaces;
using System;

namespace NoughtsAndCrosses.Services
{
    public class ConsoleWrapper : IConsole
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}