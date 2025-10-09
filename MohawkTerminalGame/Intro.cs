using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohawkTerminalGame;

namespace MohawkTerminalGame
{
    internal class Intro
    {
        public void Setup()
        {
            Program.TerminalExecuteMode = TerminalExecuteMode.ExecuteOnce;
            Program.TerminalInputMode = TerminalInputMode.KeyboardReadAndReadLine;

            Terminal.SetTitle("Intro");
            Terminal.RoboTypeIntervalMilliseconds = 50; // 50 milliseconds
            Terminal.UseRoboType = true; // use slow character typing
            Terminal.WriteWithWordBreaks = true; // donbreak around wors, don't cut them off
            Terminal.WordBreakCharacter = ' '; // break on spaces
        }

        public void Execute()
        {
            Terminal.BackgroundColor = ConsoleColor.Black;
            Terminal.WriteLine("Press SPACE to start");
            Terminal.WriteLine("");
        }
    }
}
