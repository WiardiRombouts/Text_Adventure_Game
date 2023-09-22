using System;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Text_Based_Adventure
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int progress = 0;
            int questionsAnswered;
            bool isGameRunning = true;
            string chosenpath = "";

            Console.WriteLine("Do you want load a saved game?");
            string loadSave = Console.ReadLine().ToLower();
            if (loadSave == "yes")
            {
                progress = GameLogic.ResumeGame();
                

            }
            GameLogic.EnterContinue("\nPress enter to continue");

            while (progress == 0) {
                GameLogic.StoryMessage("Welcome to Sabotage Survivors.");
                GameLogic.StoryMessage("After a plane crash caused by sabotage, you and five others must uncover the culprit among your group.");
                GameLogic.StoryMessage("Time is running out as suspicions rise.");
                GameLogic.StoryMessage("Can you find the saboteur before it`s too late?");
                GameLogic.StoryMessage("Your choices will determine the fate of all survivors.\n\n");
                GameLogic.EnterContinue("Press enter to view character stories");

                // CHARACTER STORIES

                // Wiardi
                GameLogic.StoryMessage("Wiardi is a introverted software engineer, never liked flying, but the crash made him confront his fear. \nHe observed subtle details and inconsistencies among survivors' stories, reluctantly drawn into the hunt for the saboteur, unable to resist his analytical mind.\n");
                // Nigel
                GameLogic.StoryMessage("Nigel was the seasoned pilot who had always taken pride in unsafely guiding passengers to their destinations. \nThe plane crash had made him mad, burdening him with hate for the saboteur. \nDetermined to find redemption, Nigel used his knowledge of the aircraft and keen observation skills to uncover the saboteur... and slap him in the face.\n");
                // Luna
                GameLogic.StoryMessage("Luna had faced her share of personal demons, enduring battles that left her emotionally scarred. \nThe plane crash added to her trauma, but her journey was marked by resilience. \nHer fellow survivors admired her strength in the face of adversity, and Luna's unique perspective would prove invaluable as the group sought to uncover the saboteur.\n");
                // Collin
                GameLogic.StoryMessage("Collin, the noisy wing mechanic, had always loved aircraft. \nThe crash shook his confidence in his work. Armed with mechanical insights, he methodically examined wreckage and interviewed survivors to clear his name and prove his diligence.\n");
                // Brent
                GameLogic.StoryMessage("Brent, the dedicated engine mechanic, was shaken by the plane crash and determined to find the cause. \nHe used his technical knowledge to assist in the investigation, hoping to uncover the truth and ensure justice prevailed.");
                GameLogic.EnterContinue("\nPress enter to continue");
                progress++;
            }

            while (progress == 1) {
                Console.WriteLine("Choose a character to talk to. Wiardi/Nigel/Luna/Collin/Brent");
                string choice = Console.ReadLine().ToLower();
                Console.Clear();
                if (choice.ToLower() == "wiardi")
                {
                    GameLogic.StoryMessage("You are talking to Wiardi. ");
                    GameLogic.StoryMessage("Listen, I understand your suspicions, but I can assure you, I'm not the saboteur.");
                    GameLogic.StoryMessage("I've always been anxious about flying, so why would I put myself in such a dangerous situation?");
                    GameLogic.StoryMessage("I noticed some strange behavior from one of the people before the crash, and I think it might be a clue to who did this.");
                    GameLogic.StoryMessage("Yes, I noticed something strange before the crash, and I've been trying to piece it together.");
                    GameLogic.StoryMessage("Maybe my fear and obsession with details made me look suspicious, but I want to help find the real saboteur, just like all of you. ");
                    GameLogic.StoryMessage("If you give me a chance, I can share what I've discovered, and together, we can get to the bottom of this.");

                    GameLogic.EnterContinue("\nPress enter to continue");

                    GameLogic.StoryMessage("Wiardi goes to the crash site to search for more clues.");
                    GameLogic.StoryMessage("Do you want to follow Wiardi? yes/no");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        chosenpath = "wiardi";
                    }
                    else if (choice == "no")
                    {
                        GameLogic.StoryMessage("You are going back to talk to the others");
                    }


                }
                else if (choice == "nigel")
                {
                    GameLogic.StoryMessage("It's true that I was in control, but, my friend, you must understand the complexity of flying a plane.");
                    GameLogic.StoryMessage("It's not always easy to detect sabotage, especially if someone is skilled at covering their tracks.");
                    GameLogic.StoryMessage("I was just as shocked as everyone else when the crash happened.");
                    GameLogic.StoryMessage("I also couldn't help but notice that Luna remained remarkably calm during the chaos. It was quite unusual, considering the circumstances.");
                    GameLogic.StoryMessage("If you have doubts, my friend, let's work together to uncover the truth.");

                    GameLogic.EnterContinue("\nPress enter to continue");


                    GameLogic.StoryMessage("Nigel goes back to the others to rest.");
                    Console.WriteLine("Do you want to talk to another person? yes/no");
                    choice = Console.ReadLine();
                    if (choice == "no")
                    {
                        GameLogic.EnterContinue("Press enter to ditch Nigel");
                        chosenpath = "solo";
                    }
                    else if (choice == "no")
                    {
                        GameLogic.StoryMessage("You are going back to talk to the others");
                    }
                }
                else if (choice == "luna")
                {
                    GameLogic.StoryMessage("I need you to know, I would never do something like this.");
                    GameLogic.StoryMessage("Why on earth would I put all our lives at risk, including my own?");
                    GameLogic.StoryMessage("The crash was a total nightmare, and I'm all in on finding the person responsible. ");
                    GameLogic.StoryMessage("Believe me, I'm completely committed to uncovering the real saboteur and making sure they face the consequences.\n");
                    GameLogic.StoryMessage("But, I can't help but wonder about Brent.");
                    GameLogic.StoryMessage("He was acting oddly near the engines before the crash, and it struck me as suspicious.");
                    GameLogic.StoryMessage("Maybe we should investigate his actions more closely.");
                    GameLogic.StoryMessage("\nLuna continues to investigate Brent.");
                    GameLogic.StoryMessage("Do you want to join her in her investigation? yes/no");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        chosenpath = "luna";
                    }
                    else if (choice == "no")
                    {
                        GameLogic.StoryMessage("You are going back to talk to others");
                    }

                }
                else if (choice == "collin")
                {
                    GameLogic.StoryMessage("I get where you're coming from. Safety is a big deal in my role with the wings.");
                    GameLogic.StoryMessage("Detecting sabotage can be tricky, even for someone like me.");
                    GameLogic.StoryMessage("But, man, I was just as shocked as everyone else when the crash went down.");
                    GameLogic.StoryMessage("One thing that caught my attention, though, was Wiardi. He was pretty sharp during the chaos, noticing things others might've missed.");
                    GameLogic.StoryMessage("If you've got suspicions, even about Wiardi or me, let's team up and dig deeper into this mystery.");


                    GameLogic.StoryMessage("\nCollin is going to the plane wings.");
                    Console.ReadKey();
                    GameLogic.StoryMessage("Do you want to follow him? yes/no");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        GameLogic.EnterContinue("Press enter to go to wings");
                        chosenpath = "collin";
                    }
                    else if (choice == "no")
                    {
                        GameLogic.StoryMessage("You are going back to talk to the others");
                    }
                }
                else if (choice == "brent")
                {
                    GameLogic.StoryMessage("I know my way around the engines, but messing with them would be a major risk.");
                    GameLogic.StoryMessage("I'm serious about my job, and I'd never intentionally put lives in danger.");
                    GameLogic.StoryMessage("I understand your concerns, but I was near the engines conducting routine maintenance right before the crash.");
                    GameLogic.StoryMessage("I can't deny, though, that my proximity to the engines might raise questions.");
                    GameLogic.StoryMessage("If you're looking into me, that's fair, but I want us all to find the real culprit.");
                    GameLogic.StoryMessage("\nBrent is going to the engines.");
                    GameLogic.StoryMessage("Do you want to investigate the engines? yes/no");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        GameLogic.EnterContinue("Press enter to investigate the engines");
                        
                        chosenpath = "brent";
                    }
                    else if (choice == "no")
                    {
                        GameLogic.StoryMessage("You are going back to talk to the others");
                    }
                }
                GameLogic.AskForSave(progress);


            }


            GameLogic.StoryMessage("UNDER CONSTRUCTION");
            Console.ReadKey();
            GameLogic.AskForSave(progress);
            GameLogic.EnterContinue("Press enter to continue the investigation");

            if (chosenpath == "wiardi")
            {
                progress = 2;
            }
            if (chosenpath == "nigel")
            {
                progress = 3;
            }
            if (chosenpath == "luna")
            {
                progress = 4;
            }
            if (chosenpath == "collin")
            {
                progress = 5;
            }
            if (chosenpath == "brent")
            {
                progress = 6;
            }

            while (progress == 2)
            {
                // Wiardi Seats investigation
                GameLogic.StoryMessage("You and Wiardi arrive at the passenger seats");
                GameLogic.StoryMessage("You are searching the seats");
                GameLogic.StoryMessage("Wiardi yells that he found a clue\n");
                Console.WriteLine("Do you to keep searching? yes/no");
                string choice = Console.ReadLine();

                if (choice == "yes")
                {
                    GameLogic.StoryMessage("You tell Wiardi to get it and go back to the camp");
                    GameLogic.StoryMessage("You keep searching. you find some blind snails on the ground");
                    GameLogic.StoryMessage("There also lay scissors next to the snails. You remember this for yourself");
                    GameLogic.StoryMessage("You both go back to the camp");
                    progress = 10;
                }
                else if (choice == "no")
                {
                    GameLogic.StoryMessage("You go to Wiardi and looks at what he found");
                    GameLogic.StoryMessage("[NEW CLUE] It is a wrench!");
                    GameLogic.StoryMessage("Wiardi tells you that it must be one of the mechanics!");
                    GameLogic.StoryMessage("You both go back to the camp");
                    progress = 10;
                }
                else
                {
                    GameLogic.StoryMessage("[WRONG INPUT] press enter to go back to last checkpoint");

                }
                
            }
            while (progress == 3)
            {
                // nigel, Solo investigation
                GameLogic.StoryMessage("Good job, you made nigel cry.");
                GameLogic.StoryMessage("You investigate the pilot cockpit.");
                GameLogic.StoryMessage("You look at the dashboard and see something red");
                GameLogic.StoryMessage("Do you wanna take a closer look? yes/no");
                string choice = Console.ReadLine();
                if (choice == "yes")
                {
                    GameLogic.StoryMessage("It turns out to be some kind of damage report");
                    GameLogic.StoryMessage("It shows a red blinking engine and wing symbol");
                    Console.WriteLine("You go back to camp with this information");
                    progress = 10;
                }
                if (choice == "no")
                {
                    GameLogic.StoryMessage("You are clearly very stupid");
                    GameLogic.StoryMessage("Better not be your big mistake");
                    GameLogic.StoryMessage("You go back to camp");
                    progress = 10;
                }
                else
                {
                    GameLogic.StoryMessage("[WRONG INPUT] You will now go back to your last checkpoint");
                }
            }
            while (progress == 4)
            {
                // luna Investigate brent at the engines
                GameLogic.StoryMessage("You and Luna see Brent go to the engines.");
                GameLogic.StoryMessage("You notice brent opening up some parts of the engine");
                GameLogic.StoryMessage("You ask tell Luna");
                GameLogic.StoryMessage("Luna tells you that she thinks Brent is not the saboteur ");
                GameLogic.StoryMessage("You go back to camp with Luna");
                progress = 10;
            }
            while (progress == 5)
            {
                // collin, Investigate the wings
                GameLogic.StoryMessage("You and Collin go to the wings");
                GameLogic.StoryMessage("Obviously they are very broken");
                GameLogic.StoryMessage("You tell Collin its useless to investigate here");
                GameLogic.StoryMessage("You both go back to camp");
                progress = 10;
            }
            while (progress == 6)
            {
                // brent, Investigate the engines
                GameLogic.StoryMessage("You and Brent arrive at the engines");
                GameLogic.StoryMessage("Brent opens up the engine and starts working");
                GameLogic.StoryMessage("You ask him what he is doing");
                GameLogic.StoryMessage("He tells you he is searching for sabotaged tracks");
                GameLogic.StoryMessage("You notice Luna is spying on Brent");
                GameLogic.StoryMessage("You go back to camp");
                progress = 10;
            }

            GameLogic.AskForSave(progress);
            // Final chapter
            while (progress == 10)
            {
                GameLogic.StoryMessage("You arrive back at the camp and tell everyone what you found out");
                GameLogic.StoryMessage("It is time to decide who is the saboteur");
                Console.WriteLine("Who do you think is the saboteur?");
                string saboteur = Console.ReadLine();
                if (saboteur.ToLower() == "brent")
                {
                    GameLogic.StoryMessage("Brent is left behind while you guys are being saved");
                    GameLogic.StoryMessage("You arrive back at the airport safely");
                    GameLogic.StoryMessage("You have done a good job finding out that brent was the saboteur");
                }
                else
                {
                    GameLogic.StoryMessage($"You decided to vote out {saboteur}");
                    GameLogic.StoryMessage("He is left behind and you all fly back to the airport");
                    GameLogic.StoryMessage("The plane is sabotaged again and you die");
                    GameLogic.StoryMessage("You were very stupid not thinking it was Brent as he was the saboteur");
                    GameLogic.StoryMessage("Good luck next time");
                }
            }
        }

    }
}
//"    