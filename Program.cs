using System;
using System.IO.Pipes;

namespace Text_Based_Adventure
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sabotage Survivors.");
            Console.WriteLine("After a plane crash caused by sabotage, you and five others must uncover the culprit among your group.");
            Console.WriteLine("Time is running out as suspicions rise.");
            Console.WriteLine("Can you find the saboteur before it`s too late?");
            Console.WriteLine("Your choices will determine the fate of all survivors.\n\n");
            EnterContinue("Press enter to view character stories");

            // Character stories
            
            Console.WriteLine("Wiardi is a introverted software engineer, never liked flying, but the crash made him confront his fear. \nHe observed subtle details and inconsistencies among survivors' stories, reluctantly drawn into the hunt for the saboteur, unable to resist his analytical mind.\n");

            Console.WriteLine("Nigel was the seasoned pilot who had always taken pride in unsafely guiding passengers to their destinations. \nThe plane crash had made him mad, burdening him with hate for the saboteur. \nDetermined to find redemption, Nigel used his knowledge of the aircraft and keen observation skills to uncover the saboteur... and slap him in the face.\n");

            Console.WriteLine("Luna had faced her share of personal demons, enduring battles that left her emotionally scarred. \nThe plane crash added to her trauma, but her journey was marked by resilience. \nHer fellow survivors admired her strength in the face of adversity, and Luna's unique perspective would prove invaluable as the group sought to uncover the saboteur.\n");
            
            Console.WriteLine("Collin, the noisy wing engineer, had always loved aircraft. \nThe crash shook his confidence in his work. Armed with mechanical insights, he methodically examined wreckage and interviewed survivors to clear his name and prove his diligence.\n");
            
            Console.WriteLine("Brent, the dedicated engine engineer, was shaken by the plane crash and determined to find the cause. \nHe used his technical knowledge to assist in the investigation, hoping to uncover the truth and ensure justice prevailed.");

            EnterContinue("Press enter to continue");

         
            int questionNumber = 1;
            Console.WriteLine("Choose a character to talk to");
            string person = Console.ReadLine().ToLower();
            Console.WriteLine(person);
            EnterContinue("Press enter to continue");

            ShowChozenAnswer(person, questionNumber);
        }

        // METHODS

        static void EnterContinue(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
            Console.Clear();
        }

        static void ShowChozenAnswer(string choice, int questionNumber)
        {
            if (choice == "wiardi")
            {
                Console.WriteLine();
            }
            else if (choice == "nigel")
            {
                Console.WriteLine();

            }
            else if (choice == "luna")
            {
                Console.WriteLine();

            }
            else if (choice == "collin")
            {
                Console.WriteLine();

            }
            else if (choice == "brent")
            {
                Console.WriteLine();

            }
            // After Question 1 you recieve 2 new parts to discover
            else if (questionNumber > 1)
            {
                if (choice ==  "wings")
                {
                    Console.WriteLine("damage report");
                }
                if (choice == "engine")
                {
                    Console.WriteLine("damage report");
                }
            }
            // After questoin 2 you recieve 3 new parts to discover
            else if (questionNumber > 2) {
                if (choice == "cockpit")
                {
                    Console.WriteLine("Cockpit");
                }
                if (choice == "seats")
                {

                }
            }
            

        }
    }
}
//"    