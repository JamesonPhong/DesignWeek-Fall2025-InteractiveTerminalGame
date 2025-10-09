// Introduction to the Wasteland Storyline
Console.WriteLine("You suddenly find yourself inside some sort of buggy-like vehicle chasing after another buggy-like vehicle " +
                  "at high speeds. The unbearable heat of the sun beats down upon you, feeling hotter than it usually does. " +
                  "Had it not been for the bandana wrapped tightly around your face and goggles protecting your eyes, the " +
                  "sand flying from the vehicle ahead of you would’ve blinded and choked you out.");

// This block of code pauses the dialouge to give the Player time to read.
bool pauseDialouge = true;
while (pauseDialouge == true)
{
    Console.WriteLine("");
    Console.WriteLine("Enter in the letter \"C\" To Continue...");
    string contDialouge = Console.ReadLine();
    if (contDialouge.ToLower() == "c")
    {
        pauseDialouge = false;
    }
}

Console.WriteLine("");
Console.WriteLine("Vernon (You): “What the fuck!? What’s going on!?”");
Console.WriteLine("Bandit Morrison: “Hurry up V, we’ve gotta catch up to those scum-suckers before they make off with our " +
                  "supplies!”");

pauseDialouge = true;
while (pauseDialouge == true)
{
    Console.WriteLine("");
    Console.WriteLine("Enter in the letter \"C\" To Continue...");
    string contDialouge = Console.ReadLine();
    if (contDialouge.ToLower() == "c")
    {
        pauseDialouge = false;
    }
}

Console.WriteLine("");
Console.WriteLine("Bandit Morrison: “Gyahahaha! Light ‘em up W! Let’s teach these dust-eaters what happens to thieves who " +
                  "steal supplies we stole first!”");

pauseDialouge = true;
while (pauseDialouge == true)
{
    Console.WriteLine("");
    Console.WriteLine("Enter in the letter \"C\" To Continue...");
    string contDialouge = Console.ReadLine();
    if (contDialouge.ToLower() == "c")
    {
        pauseDialouge = false;
    }
}

Console.WriteLine("");
Console.WriteLine("Glancing at the rear-view mirror you see Worsley garbed in bandit clothing on top of a gatling turret. The " +
                  "whirring of the barrel serves as a warning to the incoming storm of bullets that pelt against the fleeing " +
                  "vehicle’s shield. Very small but noticeable cracks begin to appear in the shield. One of the bandits from " +
                  "the vehicle gets up and lifts what appears to be a quad launcher. A red laser appears right in between you " +
                  "and Morrison.");

pauseDialouge = true;
while (pauseDialouge == true)
{
    Console.WriteLine("");
    Console.WriteLine("Enter in the letter \"C\" To Continue...");
    string contDialouge = Console.ReadLine();
    if (contDialouge.ToLower() == "c")
    {
        pauseDialouge = false;
    }
}

Console.WriteLine("");
Console.WriteLine("Bandit Morrison: “Shit! Dodge V! Dodge!”");

// This is the First Decision the Player can make
bool choice = true;
bool choiceOneA = false;
bool choiceOneB = false;
while (choice == true)
{
    Console.WriteLine("");
    Console.WriteLine("Enter in the Corresponding Letter to continue...");
    Console.WriteLine("");
    Console.WriteLine("[A] Dodge Left");
    Console.WriteLine("[B] Dodge Right");
    string choiceOne = Console.ReadLine();
    if (choiceOne.ToLower() == "a")
    {
        choiceOneA = true;
        choice = false;
    }
    else if (choiceOne.ToLower() == "b")
    {
        choiceOneB = true;
        choice = false;
    }
}

// This is the dialouge for Choice 1A
if (choiceOneA == true)
{
    Console.WriteLine("");
    Console.WriteLine("As you dodge the vehicle to the left, the missiles fly past you. By dodging left, you give Morrison a " +
                      "clearer opening to fire upon the vehicle. Bigger cracks appear in the fleeing vehicle’s shield, and " +
                      "you notice the occupants get a little bit more nervous. They throw something behind their vehicle. " +
                      "Suddenly, smoke appears in front of you, obscuring your vision. When you clear the smoke, the fleeing " +
                      "vehicle seems to have disappeared.");

    pauseDialouge = true;
    while (pauseDialouge == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Enter in the letter \"C\" To Continue...");
        string contDialouge = Console.ReadLine();
        if (contDialouge.ToLower() == "c")
        {
            pauseDialouge = false;
        }
    }

    Console.WriteLine("");
    Console.WriteLine("Bandit Morrison: “Damn it, where did they go!?”");
    Console.WriteLine("Vernon (You): “It looks like they either went down in the Caves here, or through the Valley.”");
    Console.WriteLine("Bandit Worsley: “There’s no way they fled to the Valley. They’d have no cover and with their energy " +
                      "shield almost down, it’d be stupid of them to leave themselves open like that. They must’ve gone down " +
                      "in the caves to hide.”");
    Console.WriteLine("Bandit Morrison: “It’d be even stupider of them to go down in the caves. You know the Underground is " +
                      "infested with those damn bugs. Even if they did go down in the caves we can cut them off at the end if " +
                      "we go through the Valley, it’s faster that way.”");

    // This is the Second Decision in Choice 1A the Player can make
    choice = true;
    bool choiceTwoA = false;
    bool choiceTwoB = false;
    while (choice == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Enter in the Corresponding Letter to continue...");
        Console.WriteLine("");
        Console.WriteLine("[A] Go down into the Caves");
        Console.WriteLine("[B] Go through the Valley");
        string choiceTwo = Console.ReadLine();
        if (choiceTwo.ToLower() == "a")
        {
            choiceTwoA = true;
            choice = false;
        }
        else if (choiceTwo.ToLower() == "b")
        {
            choiceTwoB = true;
            choice = false;
        }
    }
}
// This is the dialouge for Choice 1B
else if (choiceOneB == true)
{
    Console.WriteLine("");
    Console.WriteLine("As you dodge the vehicle to the right, the missiles fly past you. By dodging right, you give Worsley " +
                      "an opportunity to capitalize on the weakened parts of the shield. Bigger cracks appear in the fleeing " +
                      "vehicle’s shield, and you notice the occupants get a little bit more nervous. They throw something " +
                      "behind their vehicle. Suddenly, smoke appears in front of you, obscuring your vision. When you clear " +
                      "the smoke, the fleeing vehicle seems to have disappeared.");

    pauseDialouge = true;
    while (pauseDialouge == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Enter in the letter \"C\" To Continue...");
        string contDialouge = Console.ReadLine();
        if (contDialouge.ToLower() == "c")
        {
            pauseDialouge = false;
        }
    }

    Console.WriteLine("");
    Console.WriteLine("Bandit Morrison: “Damn it, where did they go!?”");
    Console.WriteLine("Vernon (You): “It looks like they either went up the Mountain, or through the Valley.”");
    Console.WriteLine("Bandit Morrison: “They’d be stupid to go into the Valley. There’s no cover, and with their energy " +
                      "shield almost down, there is no tactical value exposing themselves. They must’ve gone up the Mountain " +
                      "for a better vantage point.”");
    Console.WriteLine("Bandit Worsley: “There are Vultures up the Mountain, and we all know how territorial they are. The " +
                      "risk wouldn’t be worth the high ground advantage. Besides, if they did go up there we can just let " +
                      "the Vultures take care of ‘em.");

    // This is the Second Decision in Choice 1B the Player can make
    choice = true;
    bool choiceTwoA = false;
    bool choiceTwoB = false;
    while (choice == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Enter in the Corresponding Letter to continue...");
        Console.WriteLine("");
        Console.WriteLine("[A] Go up the Mountain");
        Console.WriteLine("[B] Go through the Valley");
        string choiceTwo = Console.ReadLine();
        if (choiceTwo.ToLower() == "a")
        {
            choiceTwoA = true;
            choice = false;
        }
        else if (choiceTwo.ToLower() == "b")
        {
            choiceTwoB = true;
            choice = false;
        }
    }
}