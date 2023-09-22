using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_Adventure
{
    internal class GameLogic
    {
        public static void StoryMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
        public static void EnterContinue(string msg)
        { 
            Console.WriteLine(msg);
            Console.ReadKey();
            Console.Clear();
        }

        public static void AskForSave(int progress)
        {
            Console.WriteLine("Do you want to continue playing? (yes/no)");
            string continueChoice = Console.ReadLine().ToLower();
            Console.Clear();
            if (continueChoice != "yes")
            {
                Console.WriteLine("Do you want to save the game? yes/no");
                string saveProgress = Console.ReadLine();
                if (saveProgress != "no")
                {
                    SaveGame(progress);
                    GameLogic.EnterContinue("Game has been saved. Press enter to close the game");
                }
                Environment.Exit(0);
            }
            EnterContinue("Press enter to continue");
        }

        public static void SaveGame(int checkpoint)
        {
            // Save the game state to a file
            using (StreamWriter writer = new StreamWriter("saved_game.txt"))
            {
                // Save relevant game state information here
                // For example, you can save the player's progress, choices, and any other necessary data
                writer.WriteLine(checkpoint);
            }
        }

        public static int ResumeGame()
        {
            string savedData = "";
            // Load the game state from a file
            if (File.Exists("saved_game.txt"))
            {
                using (StreamReader reader = new StreamReader("saved_game.txt"))
                {
                    // Read and process the saved game state here
                    // Restore the game to the saved state
                    //Console.WriteLine("Resuming game from the saved state...");
                    savedData = reader.ReadToEnd();
                    //Console.WriteLine(savedData);
                }
            }
            else
            {
                Console.WriteLine("No saved game found.");
            }
            return int.Parse(savedData);
        }
    }
}
