using System;
using Microsoft.VisualBasic.FileIO;
using MohawkTerminalGame;

namespace MohawkTerminalGame
{
    public class TerminalGame
    {
        // Place your variables here
        int playerHealth = 100;
        int enemyHealth = 100;
   

        /// Run once before Execute begins
        public void Setup()
        {
            Program.TerminalExecuteMode = TerminalExecuteMode.ExecuteLoop;
            Program.TerminalInputMode = TerminalInputMode.KeyboardReadAndReadLine;

            //Terminal.SetCursorPosition(0, 20);

            Terminal.SetTitle("Combat template");
            Terminal.RoboTypeIntervalMilliseconds = 50; // 50 milliseconds
            Terminal.UseRoboType = true; // use slow character typing
            Terminal.WriteWithWordBreaks = true; // donbreak around wors, don't cut them off
            Terminal.WordBreakCharacter = ' '; // break on spaces
        }

        // Execute() runs based on Program.TerminalExecuteMode (assign to it in Setup).
        //  ExecuteOnce: runs only once. Once Execute() is done, program closes.
        //  ExecuteLoop: runs in infinite loop. Next iteration starts at the top of Execute().
        //  ExecuteTime: runs at timed intervals (eg. "FPS"). Code tries to run at Program.TargetFPS.
        //               Code must finish within the alloted time frame for this to work well.
        public void Execute()
        {
            //Terminal.SetCursorPosition(0, 21);
            Terminal.RoboTypeIntervalMilliseconds = 0;
            Terminal.Beep();
            Terminal.WriteLine("");
            Terminal.WriteLine("[PLAYERHEALTH]");
            Terminal.WriteLine(playerHealth);
            Terminal.WriteLine("[ENEMYHEALTH]]");
            Terminal.WriteLine(enemyHealth);
            Terminal.Beep();
            Terminal.RoboTypeIntervalMilliseconds = 10;

            if (playerHealth > 0)
            {
                if (enemyHealth > 0)
                {
                    Terminal.WriteLine("");
                    Terminal.WriteLine("[FILL IN TEXT]");
                    Terminal.WriteLine("[ATTACK OPTIONS] [1,2,3]");
                    string answer = Terminal.ReadAndClearLine();
                    if (answer.ToLower().Equals("1"))
                    {
                        Terminal.RoboTypeIntervalMilliseconds = 20;
                        Terminal.WriteLine("[RESPONCE TO OPTION] = You failed, you take 20 damage.");
                        playerHealth = playerHealth - 100;
                        return;
                    }
                    else if (answer.ToLower().Equals("2"))
                    {
                        Terminal.RoboTypeIntervalMilliseconds = 20;
                        Terminal.WriteLine("[RESPONCE TO OPTION] = You deal 20 damage");
                        enemyHealth = enemyHealth - 20;
                        return;
                    }
                    else if (answer.ToLower().Equals("3"))
                    {
                        Terminal.RoboTypeIntervalMilliseconds = 20;
                        Terminal.WriteLine("[RESPONCE TO OPTION] = Wow impressive you deal 100 damage");
                        enemyHealth = enemyHealth - 100;
                        return;
                    }
                }
                else if (enemyHealth <= 0)
                {
                    Terminal.WriteLine("[RESPONCE TO VICTORY] = You did it!");
                }
            }
            else if (playerHealth <= 0)
            {
                Terminal.WriteLine("[RESPONCE TO FAILURE] = What are you? An idiot sandwich!!!!");
            }

            string end = Terminal.ReadAndClearLine();
        }

    }
}