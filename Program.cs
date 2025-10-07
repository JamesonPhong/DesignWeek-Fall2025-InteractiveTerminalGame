using System.Drawing;

Console.CursorVisible = false;
Random begin = new Random();

//skill check variables
int skillcheckSize = 5;
int barLength = 50;
int skillcheckBegin = begin.Next(10, 40);
int skillcheckEnd = skillcheckBegin + skillcheckSize;
int speed = 10;

//Moves the Bar from left to right
for (int position = 0; position < barLength; position++)
{
    Console.SetCursorPosition(0, 0);

    Console.Write("[");

    for (int i = 0; i < barLength; i++)
    {
        if (i == position)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
        }
        else if (i >= skillcheckBegin && i <= skillcheckEnd)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("=");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ");
        }

    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("]");

    Console.WriteLine();



    // makes the (any key) hit the skill check  
    if (Console.KeyAvailable) 
    {
        
        if (position >= skillcheckBegin && position <= skillcheckEnd)
        {
            Console.WriteLine("You Dodged succesfully!");
        }
        else
        {
            Console.WriteLine("You got hit!");
        }
        return;
    }
    Thread.Sleep(speed); //sets cursor speed

}