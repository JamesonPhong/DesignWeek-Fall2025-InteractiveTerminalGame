using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //scenerio counters
        bool alive = true;
        bool mutantEncounter = false;
        bool fightGiantMutant = false;
        bool inCar = false;
        bool reachedFinal = false;

        // mutant intro
        Console.WriteLine("You wake up after blacking out, your head is still killing you after the deafening noises from the wormhole almost destroyed your ears.");
        Console.WriteLine("You look around, in front of you is a small town, abandoned and eerily quiet. Behind you, a road leads into a dense forest.");
        Console.WriteLine("“Where the hell am I...? I don't recognize this place at all.”\n");
        Pause();
        //intro
        while (alive)
        {
            Console.WriteLine("Enter city or head to forest?");
            Console.WriteLine("1. Enter city");
            Console.WriteLine("2. Head toward forest");

            int choice = GetChoice(2);

            if (choice == 1)
            {
                //city option
                CityOption(ref alive, ref mutantEncounter, ref fightGiantMutant, ref inCar);
            }
            else if (choice == 2)
            {
                //forest option
                ForestOption(ref alive, ref reachedFinal);
            }

            break; 
        }

        // Die command
        if (!alive)
            Console.WriteLine("\nYou have died.");
        else
            Console.WriteLine("\nPlaceholdertext");
    }

    // city option
    static void CityOption(ref bool alive, ref bool mutantEncounter, ref bool fightGiantMutant, ref bool inCar)
    {
        Console.WriteLine("\nThe quiet town interests you, and you suspect you may find some answers here.");
        Console.WriteLine("As you walk through the town, you see no signs of life. No cars, no people, no sound.");
        Console.WriteLine("Until you hear a clanging noise from a gas station...");
        Pause();

        Console.WriteLine("Would you like to check out what's in the gas station? Or continue down the street?");
        Console.WriteLine("1. Check gas station");
        Console.WriteLine("2. Continue down street");

        int choice = GetChoice(2);

        if (choice == 2)
        {
            // Continue down street
            Console.WriteLine("\nYou decide to keep going down the street, but before you can continue, a humanoid figure appears in the gas station window.");
            Console.WriteLine("Something’s off... Its limbs are distorted, and something seems to be oozing from its body.");
            Console.WriteLine("It suddenly crashes through the window and charges you!");
            Pause();

            Console.WriteLine("You ready your combat knife and prepare to fight!");
            mutantEncounter = true;

            Console.WriteLine("\n[COMBAT: Mutant fight starts here]");
            // Placeholder for combat
            Pause();

            Console.WriteLine("\nAfter the fight, you move closer to the station and peek inside.");
            Console.WriteLine("You see another humanoid figure through the security mirror — it’s dripping with acidic ooze.");
            Pause();

            Console.WriteLine("You feel curious but uneasy. What do you do?");
            Console.WriteLine("1. Leave quietly");
            Console.WriteLine("2. Move closer to investigate");

            choice = GetChoice(2);

            if (choice == 1)
                HandleLeaveQuietly(ref alive, ref inCar, ref fightGiantMutant);
            else
                HandleInvestigate(ref alive, ref fightGiantMutant);
        }
        else if (choice == 1)
        {
            // Enter gas station
            Console.WriteLine("\nYou approach the gas station carefully and slowly open the door.");
            Console.WriteLine("Inside, you see shadows shifting and hear strange noises.");
            Pause();

            Console.WriteLine("You feel the presence of something inside...");
            Console.WriteLine("Do you want to move closer or leave quietly?");
            Console.WriteLine("1. Move closer to investigate");
            Console.WriteLine("2. Leave quietly");

            choice = GetChoice(2);

            if (choice == 1)
            {
                Console.WriteLine("\n[SKILL CHECK: Move closer to investigate]");
                bool success = RunSkillCheck();

                if (!success)
                {
                    Console.WriteLine("You make too much noise! A mutant bursts from behind the shelves and attacks!");
                    Pause();

                    mutantEncounter = true;
                    Console.WriteLine("\n[COMBAT: Mutant ambush]");
                    // Placeholder combat
                    Pause();

                    Console.WriteLine("\nAfter killing the creature, the gas station begins to shake...");
                    Console.WriteLine("An explosion rips through the building, sending debris everywhere!");
                    Pause();

                    Console.WriteLine("A gigantic mutant bursts from the alley — glowing mouth and wormhole energy within.");
                    fightGiantMutant = true;
                    return;
                }
                else
                {
                    Console.WriteLine("\nYou creep forward silently, peeking behind the shelves...");
                    Console.WriteLine("You spot a grotesque humanoid mutant crouched over something — feeding.");
                    Pause();

                    Console.WriteLine("It hasn’t noticed you yet. You slowly back away...");
                    Pause();

                    Console.WriteLine("You successfully slip out of the gas station without making a sound.");
                    Pause();

                    HandleCarEncounter(ref inCar, ref fightGiantMutant);
                }
            }
            else
            {
                Console.WriteLine("\n[SKILL CHECK: Leave quietly]");
                bool success = RunSkillCheck();

                if (!success)
                {
                    Console.WriteLine("You bump into a shelf, making a loud noise! A mutant screeches and charges!");
                    Pause();

                    mutantEncounter = true;
                    Console.WriteLine("\n[COMBAT: Mutant attack]");
                    // Placeholder combat
                    Pause();

                    Console.WriteLine("\nYou kill it, but the gas station starts rumbling...");
                    Console.WriteLine("An explosion sends you flying back, and a massive mutant emerges through the flames!");
                    fightGiantMutant = true;
                    return;
                }
                else
                {
                    Console.WriteLine("\nYou manage to slip out of the gas station unnoticed.");
                    Pause();

                    HandleCarEncounter(ref inCar, ref fightGiantMutant);
                }
            }
        }

        if (fightGiantMutant)
        {
            Console.WriteLine("\n[COMBAT: Giant mutant fight]");
            // Placeholder combat
            Pause();

            Console.WriteLine("\nYou kill the giant mutant. As it collapses, its mouth opens and the wormhole sound returns.");
            Console.WriteLine("It pulls you in, and everything fades to black...");
            Pause();
        }
    }

    // Forest option
    static void ForestOption(ref bool alive, ref bool reachedFinal)
    {
        Console.WriteLine("\nWake up In front of city\n");
        Console.WriteLine("You wake up after blacking out, your head is still killing you after the deafening noises from wormhole almost destroyed your ears. You feel your pocket, and you managed to keep a hold of your combat knife securely.\n");
        Console.WriteLine("You look around, in front of you is a small town, in no way does it look lively, abandoned almost. Behind you is a road that leads to a thick forest, trees looming high.\n");
        Console.WriteLine("“Where the hell am I… I don't recognize this place at all.\n");
        Pause();

        Console.WriteLine("Turn around and leave\n");
        Console.WriteLine("You decide this town feels eerily too quiet, and you'd rather move down the road and see what awaits.\n");
        Console.WriteLine("As you follow this road, you hear rustling coming from the forest, it sounds inhuman, like the gurking from the throat of a creature in a old horror film.\n");
        Console.WriteLine("Does your curiosity get the best of you?\n");
        Console.WriteLine("1. Investigate");
        Console.WriteLine("2. Ignore / Turn away and continue down the road");

        int firstChoice = GetChoice(2);

        if (firstChoice == 1)
        {
            // Investigate 
            Console.WriteLine("\nInvestigate\n");
            Console.WriteLine("You slowly creep towards this awful noise, before finally peaking over the bushes, and what you see slightly sets you back, regardless to the other…. Entities you've seen.\n");
            Console.WriteLine("You see a human like creature with mutilated limbs, leaking ooze from gashed open crevasses of its body, heaving in and out heavily as it seems like its encapsulated by something in the trees.\n");
            Console.WriteLine("You wonder what this mutant thing is, and how many more are in this place. You dont have the best view of this mutant creature, and youre not sure if its even cohesively sentient, is this worth investigating? Or is it worth risking your life?\n");
            Console.WriteLine("1. Leave");
            Console.WriteLine("2. Move closer");

            int investigateChoice = GetChoice(2);

            if (investigateChoice == 1)
            {
                // Leave = skill check. if success go to ignore noise page, if no go to move closer
                Console.WriteLine("\nLeave (skill check)");
                bool sneakSuccess = RunSkillCheck();
                if (sneakSuccess)
                {
                    Console.WriteLine("\nYou sneak away successfully.");
                    Pause();
                    IgnorePath(ref alive, ref reachedFinal);
                }
                else
                {
                    Console.WriteLine("\nYou make noise while trying to leave.");
                    Pause();
                    HandleMoveCloserPath(ref alive, ref reachedFinal);
                }
            }
            else
            {
                HandleMoveCloserPath(ref alive, ref reachedFinal);
            }
        }
        else
        {
            IgnorePath(ref alive, ref reachedFinal);
        }

        if (reachedFinal && alive)
        {
            Console.WriteLine("\n[COMBAT]");
            Console.WriteLine("\nAs the creature drops to the ground in defeat, its mouth opens, wider and wider, before that horrid sound begins to emit again, except this time, you accept the outcome as a step closer to going home.");
            Pause();
        }
    }

    // Story option commands
    static void HandleMoveCloserPath(ref bool alive, ref bool reachedFinal)
    {
        Console.WriteLine("\nMove closer\n");
        Console.WriteLine("The noise you make attracts the creatures attention.");
        Console.WriteLine("It snaps its head at you, and immediately dashes at you, limbs not function as purposed, but still making Its approach.\n");
        Console.WriteLine("[Combat]\n");
        Pause();

        Console.WriteLine("You beat this creature down until it stops moving, you make it out fine, but have some harsh burns from the acidic like blood.");
        Console.WriteLine("You examine the creature and determine its dead. You see it closely resembles humanoid properties, but many things have almost… shifted on its body.\n");
        Console.WriteLine("Its teeth aren't correctly aligned, the jaw line is almost lower, the eyes are at different levels, and one has 2 iris’s, both different colours. Its leg seemed to toughen and straighten to the point it dosnt bend anymore\n");
        Console.WriteLine("“Jesus Christ, what happened to this thing, was this a human before? Or was it creates, and why does its blood sting like holy hell”\n");
        Pause();

        Console.WriteLine("Amidst talking to yourself, in the distance you hear a very familiar voice.\n");
        Console.WriteLine("It's Morrison.\n");
        Console.WriteLine("“Vernon! Vernon!” he yells, sounding in distress\n");
        Pause();

        Console.WriteLine("You didn't see Morrison get sucked into the wormhole, but you were the first to go in, so you don't know if he got pulled in here too. You need to make a decision soon.\n");
        Console.WriteLine("1. Go towards Morrison's voice");
        Console.WriteLine("2. Ignore voice");

        int morrisonChoice = GetChoice(2);

        if (morrisonChoice == 2)
        {
            Console.WriteLine("\nIgnore voice\n");
            IgnorePath(ref alive, ref reachedFinal);
            return;
        }

        // Go towards voice
        Console.WriteLine("\nGo towards the voice.\n");
        Console.WriteLine("You start going towards Morrison's voice, slowly as you are unsure of your current situation, as you clear the bushes, Morrison's voice grows louder and louder, the closer you get, the more inhuman it sounds before finally entering a clearing to see another mutant, this time with tendrils coming out of its body.\n");
        Console.WriteLine("You see it estrangly moves its mouth as it says “Vernon!,  Vernon.\n");
        Pause();

        Console.WriteLine("Your hope drops from your body, but your situation calls for you to leave, before this thing notices you.\n");
        Console.WriteLine("You turn around to escape, but before you do, your eyes linger to the floor\n");
        Console.WriteLine("You see the same tentacles that extended from the mutant on the ground. The ground around you becomes infested with these tentacles, all searching for something.\n");
        Console.WriteLine("You quickly learn that this thing doesn't know you're hear, if it did, you'd have a lot more issues.\n");
        Console.WriteLine("You also know you cant leave until this thing dies, so you grip your knife, and begin to go in.\n");
        Console.WriteLine("You slowly creep up to this mutant, before stabbing it right in the throat, and with one clean cut, it drops to the floor.\n");
        Console.WriteLine("The tentacles grow motionless, and everything goes quiet\n");
        Pause();

        Console.WriteLine("\nUntil you feel the ground shake again, this time much louder, and closer.\n");
        Console.WriteLine("From through the trees, branches push aside, and emerges a large, barely humanoid mutant, but somethings different\n");
        Console.WriteLine("As it spots at you, it lets out a loud, familiar roar, similar to the sounds the wormhole made.\n");
        Console.WriteLine("Deep in its mouth, you barely get a glance of it, but you recognize it as the same geometrical shape that creates the wormhole.\n");
        Console.WriteLine("You know if you want a chance to get home\n");
        Console.WriteLine("This. thing. Needs. To. die.\n");
        Pause();

        Console.WriteLine("[combat ]\n");
        reachedFinal = true;
    }

    static void IgnorePath(ref bool alive, ref bool reachedFinal)
    {
        Console.WriteLine("\nIgnore\n");
        Console.WriteLine("You decide that whatever is in there, isn't worth checking out");
        Console.WriteLine("You continue down the road, but with the eerie feeling you're being watched, you look around, but nothing seems obviously out of place around you.");
        Console.WriteLine("After a few kilometers of walking, you find a lone house, looks unmanaged, slightly damaged and overgrown.");
        Console.WriteLine("You also spot a car, looking in usable condition.");
        Pause();

        Console.WriteLine("Would you like to investigate this house? Or take the car and make more distance.");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. House");

        int choice = GetChoice(2);

        if (choice == 1)
        {
            // Car option
            Console.WriteLine("\nCar\n");
            Console.WriteLine("You go over to the car and look inside, theres keys sitting on the seat, you get in and put the keys in the ignition.\n");
            Console.WriteLine("As you attempt to start the car, it stalls, and without warning the cars theft alarm triggers\n");
            Console.WriteLine("“GOD DAMNIT, WHY THE HELL DID IT DO THAT”\n");
            Pause();

            bool breakSuccess = RunSkillCheck();

            if (!breakSuccess)
            {
                Console.WriteLine("\nYou fail to break out in time and the mutant attacks. You die.");
                alive = false;
                return;
            }

            Console.WriteLine("\nYou break through the window and crawl out.");
            Console.WriteLine("Now theres one last thing you need to break, and thats the only thing that can get you home.\n");
            Console.WriteLine("[combat]\n");
            Pause();
            reachedFinal = true;
        }
        else
        {
            // House option
            Console.WriteLine("\nHouse\n");
            Console.WriteLine("You walk towards the house, its run down, like no ones maintenance it in ages, the front door looks functional regardless.");
            Console.WriteLine("You reach towards the door handle, and before you get a hold of the handle, the door flies open.");
            Console.WriteLine("You're greeted face to face by the end of a shotgun.");
            Console.WriteLine("Behind that shotgun is a woman, who has a panicked expression on her face");
            Console.WriteLine("You are seen as a threat, but she spits out a few words\n");
            Console.WriteLine("“W-why are you here, leave me alone”\n");
            Pause();

            Console.WriteLine("She's willing to listen to you, but not conflicted to shoot you if you make the wrong move, what do you do?");
            Console.WriteLine("1. Talk it out");
            Console.WriteLine("2. Grab the gun.");

            int houseChoice = GetChoice(2);

            if (houseChoice == 1)
            {
                // Talk it out option
                Console.WriteLine("\nTalk it out\n");
                Console.WriteLine("Dialogue continues as written...");
                Pause();
                reachedFinal = true;
            }
            else
            {
                // Grab gun option
                Console.WriteLine("\nGrab the gun\n");
                bool gunSuccess = RunSkillCheck();

                if (!gunSuccess)
                {
                    Console.WriteLine("\nYou fail and die!");
                    alive = false;
                    return;
                }

                Console.WriteLine("\nYou grab the gun and prepare for the fight...");
                Pause();
                reachedFinal = true;
            }
        }
    }

    static void HandleLeaveQuietly(ref bool alive, ref bool inCar, ref bool fightGiantMutant)
    {
        Console.WriteLine("\n[SKILL CHECK: Leave quietly]");
        bool success = RunSkillCheck();

        if (!success)
        {
            Console.WriteLine("You make too much noise! A mutant hears you and attacks!");
            Pause();

            Console.WriteLine("\n[COMBAT: Mutant attacks you]");
            Pause();
        }
        else
        {
            Console.WriteLine("\nYou quietly leave the gas station and continue down the street.");
            Pause();
            HandleCarEncounter(ref inCar, ref fightGiantMutant);
        }
    }

    static void HandleInvestigate(ref bool alive, ref bool fightGiantMutant)
    {
        Console.WriteLine("\n[SKILL CHECK: Move closer to investigate]");
        bool success = RunSkillCheck();

        if (!success)
        {
            Console.WriteLine("You make too much noise! The mutant hears you and attacks!");
            Pause();

            Console.WriteLine("\n[COMBAT: Mutant attacks you]");
            Pause();
        }
        else
        {
            Console.WriteLine("\nYou silently creep closer, peeking around the corner...");
            Pause();

            Console.WriteLine("It suddenly turns and charges! You ready your knife!");
            Console.WriteLine("\n[COMBAT: Mutant close fight]");
            Pause();

            Console.WriteLine("\nAfter defeating it, the gas station explodes behind you.");
            Console.WriteLine("From the smoke emerges the massive mutant — the one with the wormhole shape in its mouth!");
            fightGiantMutant = true;
        }
    }

    static void HandleCarEncounter(ref bool inCar, ref bool fightGiantMutant)
    {
        Console.WriteLine("\nAs you walk further down the street, you spot a car approaching with one man inside.");
        Console.WriteLine("You wave him down, and he hesitantly pulls over.");
        inCar = true;
        Pause();

        Console.WriteLine("The man rolls down the window and turns off the engine.");
        Console.WriteLine("Dialogue continues as written...");
        Pause();

        
        fightGiantMutant = true;
        inCar = false;
    }

    // commands 
    static int GetChoice(int max)
    {
        int choice = 0;
        while (true)
        {
            Console.Write("Choice: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                if (choice >= 1 && choice <= max)
                    break;
            }
            Console.WriteLine($"Please enter a number between 1 and {max}.");
        }
        return choice;
    }

    static void Pause()
    {
        Console.WriteLine("\n(Press any key to continue...)");
        Console.ReadKey(true);
        Console.Clear();
    }

    static bool RunSkillCheck()
    {
        Console.CursorVisible = false;
        Console.Clear();

        Random begin = new Random();
        int skillcheckSize = 5;
        int barLength = 50;
        int skillcheckBegin = begin.Next(10, 40);
        int skillcheckEnd = skillcheckBegin + skillcheckSize;
        int speed = 30;

        Console.WriteLine(" SKILL CHECK ");
        Console.WriteLine("Press SPACE when the white bar is inside the red zone!");
        Console.WriteLine();

        for (int position = 0; position < barLength; position++)
        {
            Console.SetCursorPosition(0, 3);
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
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("]");

            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.CursorVisible = true;
                    return position >= skillcheckBegin && position <= skillcheckEnd;
                }
            }

            Thread.Sleep(speed);
        }

        Console.Clear();
        Console.CursorVisible = true;
        return false;
    }
}
