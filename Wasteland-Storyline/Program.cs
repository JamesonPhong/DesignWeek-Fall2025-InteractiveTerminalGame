








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
bool choiceTwoA = false;
bool choiceTwoB = false;
bool choiceThreeA = false;
bool choiceThreeB = false;
bool worsleyDead = false;
bool morrisonDead = false;
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
// This is the dialouge for Choice 2A in Choice 1A
if (choiceOneA == true && choiceTwoA == true)
{
    Console.WriteLine("");
    Console.WriteLine("Steering the buggy into the cave, you turn the headlights on. Immediately, you hear the sound of " +
                      "skittering echoing faintly in the walls. As you navigate through the cave the skittering gets louder " +
                      "until finally you are faced with scorpion-like bugs.");

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
    Console.WriteLine("Bandit Morrison: “I knew this would happen… Get ready boys! Looks like we’re in for one helluva fight!”");

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
    Console.WriteLine("Vernon (You): “The path is clear, everybody in!”");

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
    Console.WriteLine("The buggy shakes hard from behind and you hear a visceral scream behind you. As you turn you watch in " +
                      "horror as Worsley is grabbed by a bug hidden in the shadows. Bugs swarm Worsley, ripping him apart " +
                      "limb from limb. His pained cries echo in the Cave as the Bugs greedily feast on him. They all take " +
                      "chunks out of him, blood painting the walls as his half-chewed organs wetly squelches on the ground. " +
                      "All you can hear is dripping blood. You quickly make your way through the bloodied corpses of the bugs " +
                      "and see a light ahead indicating the end of the Cave. As you clear the cave, you see the fleeing " +
                      "vehicle just ahead resting at a cliffside. They seemed to have run out of fuel.");
    
    worsleyDead = true;
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
    Console.WriteLine("Bandit Morrison: “Ohohoho! There they are! Time to end this!”");
}
// This is the dialouge for Choice 2A in Choice 1B
else if (choiceOneB == true && choiceTwoA == true)
{
    Console.WriteLine("");
    Console.WriteLine("Steering the buggy up the Mountain, you carefully follow the pathways. Immediately you hear screeching " +
                      "echoing in the distance. As you navigate the road you notice a dust cloud far below the mountain, but " +
                      "then you hear the screeching become louder. Up ahead you see tiny dots in the sky. The Vultures are " +
                      "rapidly approaching.");

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
    Console.WriteLine("Bandit Worsley: “Good news, we found the scrapheads. Bad news, the Vultures found us too!”");

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
    Console.WriteLine("Vernon (You): “I see the way down, come on!”");

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
    Console.WriteLine("A loud crash shakes the buggy and you hear a guttural cry to your right. You turn your head just in " +
                      "time to see a Vulture carrying Morrison away up into the air. He screams in terror as he’s tossed " +
                      "between the Vultures. They all take turns tearing him apart, blood raining from the sky as his maimed " +
                      "body splatters on the ground. A grotesque thud is heard. You book it down the Mountain, the downward " +
                      "slope adding extra speed to the buggy’s descent. As you reach the base of the Mountain, you see the " +
                      "fleeing vehicle just ahead resting at a cliffside. They seemed to have run out of fuel.");

    morrisonDead = true;
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
    Console.WriteLine("Bandit Worsley: “Bastards are done now! Let’s finish ‘em off!”");
}
// This is the dialouge for Choice 2B in Choice 1A or Choice 1B
else if (choiceOneA == true || choiceOneB == true && choiceTwoB == true)
{
    Console.WriteLine("");
    Console.WriteLine("Going straight into the Valley you eventually find the fleeing vehicle just up ahead, the cracks in " +
                      "the shield slowly repairing itself. Morrison and Worsley rain hellfire once again upon the fleeing " +
                      "vehicle.");

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
    Console.WriteLine("Bandit Morrison: “We ain’t gonna get nowhere like this! Oi V, you can multi-task can’t you? Get your " +
                      "gun out and help us break that damn shield, oh and try not to crash us!”");

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
    Console.WriteLine("You managed to nail a hit on the fleeing vehicle’s fuel line causing them to lose fuel and leading to " +
                      "them slowing down significantly until they eventually are forced to stop at a cliffside.");

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
    Console.WriteLine("Bandit Morrison: “Hah! They’ve got nowhere to run to now! Time to end this!”");
}
// This is the Third and Final Decision the Player can make
choice = true;
while (choice == true)
{
    Console.WriteLine("");
    Console.WriteLine("Enter in the Corresponding Letter to continue...");
    Console.WriteLine("");
    Console.WriteLine("[A] Ram them");
    Console.WriteLine("[B] Stop the car");
    string choiceThree = Console.ReadLine();
    if (choiceThree.ToLower() == "a")
    {
        choiceThreeA = true;
        choice = false;
    }
    else if (choiceThree.ToLower() == "b")
    {
        choiceThreeB = true;
        choice = false;
    }
}
// This is the dialouge for Choice 3A
if (choiceThreeA == true)
{
    Console.WriteLine("");
    Console.WriteLine("You ram the car sending both you and the fleeing bandits straight off the cliffside.");
}
// This is the dialouge for Choice 3B
else if (choiceThreeB == true)
{
    // Checks if Morrison is dead from Choice 2A in Choice 1B
    if (morrisonDead == true)
    {
        Console.WriteLine("");
        Console.WriteLine("After defeating the bandits, Worsley begins to re-loot the supplies they stole before.");

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
        Console.WriteLine("Bandit Worsley: “What’s this? When did we loot this?”");

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
        Console.WriteLine("Worsley opens up the half-open trunk revealing the specimen. Your eyes widen in recognition and " +
                          "you rush over.");
    }
    // If Morrison is still alive or Worsley is dead from Choice 2A in Choice 1A
    else
    {
        Console.WriteLine("");
        Console.WriteLine("After defeating the bandits, Morrison begins to re-loot the supplies they stole before.");

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
        Console.WriteLine("Bandit Morrison: “Huh? I don’t remember looting this.”");

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
        Console.WriteLine("Morrison opens up the half-open trunk revealing the specimen. Your eyes widen in recognition and " +
                          "you rush over.");
    }
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
    Console.WriteLine("Vernon (You): “What have you done, where are we!?”");

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

    if (morrisonDead == true)
    {
        Console.WriteLine("");
        Console.WriteLine("The specimen screeches causing you and Worsley to hold your heads in pain. The eerie purple glow " +
                          "from before appears around the specimen again as it floats up several feet in the air. Particles " +
                          "begin eating away at your surroundings like before until you once again find yourself being pulled " +
                          "into the vortex.");
    }
    else if (worsleyDead == true)
    {
        Console.WriteLine("");
        Console.WriteLine("The specimen screeches causing you and Morrison to hold your heads in pain. The eerie purple glow " +
                          "from before appears around the specimen again as it floats up several feet in the air. Particles " +
                          "begin eating away at your surroundings like before until you once again find yourself being pulled " +
                          "into the vortex.");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("The specimen screeches causing you, Morrison and Worsley to hold your heads in pain. The eerie " +
                          "purple glow from before appears around the specimen again as it floats up several feet in the air. " +
                          "Particles begin eating away at your surroundings like before until you once again find yourself " +
                          "being pulled into the vortex.");
    }
    // The Player returns back to the Facility
    Console.WriteLine("");
    Console.WriteLine("As you return back to the facility, you look around disoriented. Morrison grabs you by the shoulder.");

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
    Console.WriteLine("Sgt. Morrison: “Hey, are you alright? You’ve been staring at the specimen for a while now.”");
    Console.WriteLine("Vernon (You): “I don’t know… I was just in some sort of alternate reality I think? My head kind of " +
                      "hurts…”");
    Console.WriteLine("Sgt. Morrison: “Alright come with me, we need to get you to sickbay for a checkup, you know the drill.”");

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
    Console.WriteLine("Both of you exit the room and head towards Sickbay. On the way you pass by the Security Checkpoint " +
                      "where Worsley is stationed.");

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
    Console.WriteLine("Specialist Worsley: “Is everything alright!? I heard the alarm go off and I was about to call in a " +
                      "detachment.”");
    Console.WriteLine("Sgt. Morrison: “Vernon had an experience with the specimen, I’m taking him to Sickbay for a deep " +
                      "analysis.”");
    Console.WriteLine("Specialist Worsley: “What do you mean by experience?”");
    Console.WriteLine("Sgt. Morrison: “We’ll talk about it later, right now making sure Vernon isn’t affected by the specimen " +
                      "is more important.”");

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
    // Endings based on who is alive
    // This Ending depends on if Worsley is dead from Choice 2A in Choice 1A
    if (worsleyDead == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Approaching the end of the hallway, the images of Worsley’s horrible mutilation as he died " +
                          "tragically in the alternate reality comes back to mind. As you round the corner and look at " +
                          "Worsley one last time, you notice something… Weren’t Worsley’s eyes blue?");
    }
    // This Ending depends on if Morrison is dead from Choice 2A in Choice 1B
    else if (morrisonDead == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Approaching the end of the hallway, the sound of Morrison’s haunting screams as he died tragically " +
                          "in the alternate reality echo in your ear. As you arrive at Sickbay and watch as Morrison leaves, " +
                          "you notice something… Where did Morrison’s scar go?");
    }
    // This Ending depends on if both Worsley and Morrison are alive
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Approaching the end of the hallway, your headache starts feeling a bit worse. As you round the " +
                          "corner, you thought you heard somebody whisper your name… Was that your voice?");
    }
}








