using System;
using System.Text.RegularExpressions;

namespace _3_4_Lab_Maskevich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");

            //  2a.Find all of the occurrences of the letter ‘d’ or ‘e’‘   REGEX[d - e]

            string patternA = @"[d-e]";
            string inputA = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            RegexOptions optionsA = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(inputA, patternA, optionsA))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            // 2b.Find all of the occurrences of the letter ‘d’ or’ e’, followed by another ‘d’   REGEX[d - e][*d]

            string patternB = @"[d-e][*d]";
            string inputB = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            RegexOptions optionsB = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(inputB, patternB, optionsB))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }


            // 2c.Find all of the occurrences of the letter ‘a’, followed by any letter, then the letter ‘a’ again   REGEX[a][a-z][a]

            string patternC = @"[a][a-z][a]";
            string inputC = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            RegexOptions optionsC = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(inputC, patternC, optionsC))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            // 2d. Find all of the words that start with the letter “p”   REGEX[][p][a - z]*

            string patternD = @"[ ][p][a-z]*";
            string inputD = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            RegexOptions optionsD = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(inputD, patternD, optionsD))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            // 2e. Find all of the words that end with the letter e   REGEX[a - z]*[e][]

            string patternE = @"[a-z]*[e][ ]";
            string inputE = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            RegexOptions optionsE = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(inputE, patternE, optionsE))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            // 2f. Find all of the capital letters  REGEX[A - Z]

            string patternF = @"[A-Z]";
            string inputF = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            RegexOptions optionsF = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(inputF, patternF, optionsF))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }





        }
    }
}
