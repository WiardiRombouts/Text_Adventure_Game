using System;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace Text_Based_Adventure
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int progress = 0;
            int questionsAnswered;
            bool isGameRunning = true;

            Console.WriteLine("Do you want load a saved game?");
            string loadSave = Console.ReadLine().ToLower();
            if (loadSave == "yes")
            {
                progress = GameLogic.ResumeGame();
                

            }
            GameLogic.EnterContinue("\nPress enter to continue");

            while (progress == 0) {
                Console.WriteLine("Welcome to Sabotage Survivors.");
                Console.WriteLine("After a plane crash caused by sabotage, you and five others must uncover the culprit among your group.");
                Console.WriteLine("Time is running out as suspicions rise.");
                Console.WriteLine("Can you find the saboteur before it`s too late?");
                Console.WriteLine("Your choices will determine the fate of all survivors.\n\n");
                GameLogic.EnterContinue("Press enter to view character stories");

                // CHARACTER STORIES

                // Wiardi
                Console.WriteLine("Wiardi is a introverted software engineer, never liked flying, but the crash made him confront his fear. \nHe observed subtle details and inconsistencies among survivors' stories, reluctantly drawn into the hunt for the saboteur, unable to resist his analytical mind.\n");
                // Nigel
                Console.WriteLine("Nigel was the seasoned pilot who had always taken pride in unsafely guiding passengers to their destinations. \nThe plane crash had made him mad, burdening him with hate for the saboteur. \nDetermined to find redemption, Nigel used his knowledge of the aircraft and keen observation skills to uncover the saboteur... and slap him in the face.\n");
                // Luna
                Console.WriteLine("Luna had faced her share of personal demons, enduring battles that left her emotionally scarred. \nThe plane crash added to her trauma, but her journey was marked by resilience. \nHer fellow survivors admired her strength in the face of adversity, and Luna's unique perspective would prove invaluable as the group sought to uncover the saboteur.\n");
                // Collin
                Console.WriteLine("Collin, the noisy wing engineer, had always loved aircraft. \nThe crash shook his confidence in his work. Armed with mechanical insights, he methodically examined wreckage and interviewed survivors to clear his name and prove his diligence.\n");
                // Brent
                Console.WriteLine("Brent, the dedicated engine engineer, was shaken by the plane crash and determined to find the cause. \nHe used his technical knowledge to assist in the investigation, hoping to uncover the truth and ensure justice prevailed.");
                GameLogic.EnterContinue("\nPress enter to continue");
                progress++;
            }


            while (progress == 1) {
                Console.WriteLine("Choose a character to talk to. Wiardi/Nigel/Luna/Collin/Brent");
                string choice = Console.ReadLine().ToLower();
                if (choice == "wiardi")
                {
                    Console.WriteLine("You are talking to Wiardi. ");
                    Console.ReadKey();
                    Console.WriteLine("Listen, I understand your suspicions, but I can assure you, I'm not the saboteur.");
                    Console.ReadKey();
                    Console.WriteLine("I've always been anxious about flying, so why would I put myself in such a dangerous situation?");
                    Console.ReadKey();
                    Console.WriteLine("I noticed some strange behavior from one of the people before the crash, and I think it might be a clue to who did this.");
                    Console.ReadKey();
                    Console.WriteLine("Yes, I noticed something strange before the crash, and I've been trying to piece it together.");
                    Console.ReadKey();
                    Console.WriteLine("Maybe my fear and obsession with details made me look suspicious, but I want to help find the real saboteur, just like all of you. ");
                    Console.ReadKey();
                    Console.WriteLine("If you give me a chance, I can share what I've discovered, and together, we can get to the bottom of this.");
                    Console.ReadKey();

                    GameLogic.EnterContinue("\nPress enter to continue");

                    Console.WriteLine("Wiardi goes to the crash site to search for more clues.");
                    Console.ReadKey();
                    Console.WriteLine("Do you want to follow Wiardi? yes/no");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        progress++;
                    }
                    

                }
                else if (choice == "nigel")
                {
                    Console.WriteLine("It's true that I was in control, but, my friend, you must understand the complexity of flying a plane.");
                    Console.ReadKey();
                    Console.WriteLine("It's not always easy to detect sabotage, especially if someone is skilled at covering their tracks.");
                    Console.ReadKey();
                    Console.WriteLine("I was just as shocked as everyone else when the crash happened.");
                    Console.ReadKey();
                    Console.WriteLine("I also couldn't help but notice that Luna remained remarkably calm during the chaos. It was quite unusual, considering the circumstances.");
                    Console.ReadKey();
                    Console.WriteLine("If you have doubts, my friend, let's work together to uncover the truth.");
                    Console.ReadKey();

                    GameLogic.EnterContinue("\nPress enter to continue");

                    Console.WriteLine("Nigel goes back to the others to rest.");
                    Console.ReadKey();
                    Console.WriteLine("Do you want to talk to another person? yes/no");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        progress++;
                    }
                }
                else if (choice == "luna")
                {
                    Console.WriteLine("I need you to know, I would never do something like this.");
                    Console.ReadKey();
                    Console.WriteLine("Why on earth would I put all our lives at risk, including my own?");
                    Console.ReadKey();
                    Console.WriteLine("The crash was a total nightmare, and I'm all in on finding the person responsible. ");
                    Console.ReadKey();
                    Console.WriteLine("Believe me, I'm completely committed to uncovering the real saboteur and making sure they face the consequences.\n");
                    Console.ReadKey();
                    Console.WriteLine("But, I can't help but wonder about Brent.");
                    Console.ReadKey();
                    Console.WriteLine("He was acting oddly near the engines before the crash, and it struck me as suspicious.");
                    Console.ReadKey();
                    Console.WriteLine("Maybe we should investigate his actions more closely.");
                    Console.ReadKey();

                    Console.WriteLine("Luna continues to investigate Brent.");
                    Console.ReadKey();
                    Console.WriteLine("Do you want to join her in her investigation? yes/no");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        progress++;
                    }
                    else if (choice == "no")
                    {
                        Console.WriteLine("You are going back to talk to others");
                    }

                }
                else if (choice == "collin")
                {
                    Console.WriteLine("I get where you're coming from. Safety is a big deal in my role with the wings.");
                    Console.ReadKey();
                    Console.WriteLine("Detecting sabotage can be tricky, even for someone like me.");
                    Console.ReadKey();
                    Console.WriteLine("But, man, I was just as shocked as everyone else when the crash went down.");
                    Console.ReadKey();
                    Console.WriteLine("One thing that caught my attention, though, was Wiardi. He was pretty sharp during the chaos, noticing things others might've missed.");
                    Console.ReadKey();
                    Console.WriteLine("If you've got suspicions, even about Wiardi or me, let's team up and dig deeper into this mystery.");
                    Console.ReadKey();

                }
                else if (choice == "brent")
                {
                    Console.WriteLine("I know my way around the engines, but messing with them would be a major risk.");
                    Console.ReadKey();
                    Console.WriteLine("I'm serious about my job, and I'd never intentionally put lives in danger.");
                    Console.ReadKey();
                    Console.WriteLine("I understand your concerns, but I was near the engines conducting routine maintenance right before the crash.");
                    Console.ReadKey();
                    Console.WriteLine("I can't deny, though, that my proximity to the engines might raise questions.");
                    Console.ReadKey();
                    Console.WriteLine("If you're looking into me, that's fair, but I want us all to find the real culprit.");
                    Console.ReadKey();


                }
                GameLogic.AskForSave(progress);


            }


            while (progress == 2)
            {
                Console.WriteLine("UNDER CONSTRUCTION");
                Console.ReadKey();
                GameLogic.AskForSave(progress);

            }
        }

    }
}
//"    