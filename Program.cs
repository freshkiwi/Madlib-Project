using System;

namespace Game
{
    static class Madlib
    {
        //declare variables
        /*static string Creature;
        static string Luminous;
        static string Ghastly;
        static string Spectral;
        static string Countryman;
        static string Farrier;
        static string Farmer;
        static string Dreadful;
        static string Apparition;
        static string Hound;*/
        static string Story;
       
        static string[] Words =
        {
            "creature",
            "luminous",
            "ghastly",
            "spectral",
            "countryman",
            "farmer",
            "farrier",
            "dreaful",
            "apparition",
            "hound",
        };
        static string[] Prompts =
        {
            "noun",
            "adjective",
            "adjective",
            "adjective",
            "occupation",
            "occupation",
            "occupation",
            "adjective",
            "noun",
            "noun"
        };

        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            //write header and instructions
            Console.WriteLine("-------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("-------");
        }
        
        static void GetWords()
        {
            //ask player to enter words
            for (int i =0; i< Words.Length; i++)
            {
                Console.Write("Please enter a/an " + Prompts[i] + ": ");
                Words[i] = Console.ReadLine();
            }
            /*Console.Write("Please enter a noun: ");
            Creature = Console.ReadLine();

            Console.Write("Please enter a adjective: ");
            Luminous = Console.ReadLine();

            Console.Write("Please enter a adjective: ");
            Ghastly = Console.ReadLine();

            Console.Write("Please enter a adjective: ");
            Spectral = Console.ReadLine();

            Console.Write("Please enter a occupation: ");
            Countryman = Console.ReadLine();

            Console.Write("Please enter a occupation: ");
            Farrier = Console.ReadLine();

            Console.Write("Please enter a occupation: ");
            Farmer = Console.ReadLine();

            Console.Write("Please enter a adjetive: ");
            Dreadful = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Apparition = Console.ReadLine();

            Console.Write("Please enter a noun: ");
            Hound = Console.ReadLine();*/
        }
        static void WriteStory()
        {
            //write out finished story
            Story = "They all agreed that it was a huge {0}, {1}, {2}, and {3}. \nI have cross-examined these men, one of them a hard-headed {4}, one a {5}, and one a moorland {6}, who all tell the same story of this {7}, {8}, exactly corresponding to the {9} of the legend.";
            Console.WriteLine(Story, Words[0], Words[1], Words[2], Words[3], Words[4], Words[5], Words[6], Words[7], Words[8], Words[9]);
        }
        static void End()
        { 
            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            Madlib.Run();
        }
    }
}
