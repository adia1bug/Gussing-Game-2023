namespace Gussing_game20231
{
    //internal class Program
    
    //using System;

public class RnBArtistGuessingGame
    {
        private static int i;

        public static void Main()
        {
            // Create a list of R&B artists.
            List<string> rnBArtists = new List<string> {
            "Aaliyah",
            "Beyoncé",
            "Chris Brown",
            "Erykah Badu",
            "Ginuwine",
            "H.E.R.",
            "Jazmine Sullivan",
            "Kanye West",
            "Mary J. Blige",
            "The Weeknd"
        };

            // Shuffle the list of R&B artists.
            var random = new Random();
           // random.Shuffle(rnBArtists);

            // Ask the user 10 questions about R&B artists.
            for (int i = 0; i < 10; i++)
            {
                // Get the current R&B artist.
                string currentArtist = rnBArtists[i];

                // Ask the user a question about the current R&B artist.
                switch (random.Next(3))
                {
                    case 0:
                        Console.WriteLine("What is the first name of " + currentArtist + "?");
                        break;
                    case 1:
                        Console.WriteLine("What is the last name of " + currentArtist + "?");
                        break;
                    case 2:
                        Console.WriteLine("What is the birthdate of " + currentArtist + "?");
                        break;
                }
                string userAnswer = Console.ReadLine();

                // Check if the user's answer is correct.
                bool isCorrect = false;
                switch (random.Next(3))
                {
                    case 0:
                        isCorrect = userAnswer == currentArtist.Split(' ')[0];
                        break;
                    case 1:
                        isCorrect = userAnswer == currentArtist.Split(' ')[1];
                        break;
                    case 2:
                        //isCorrect = userAnswer.Contains(currentArtist.Split(' ')[0]) && userAnswer.Contains(currentArtist.Split(' ')[1]);
                        break;
                }

                if (isCorrect)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! The correct answer is " + currentArtist.Split(' ')[0] + " " + currentArtist.Split(' ')[1]);
                }
            }

            // Tell the user the number of questions they answered correctly.
            Console.WriteLine("You answered " + (10 - i) + " questions correctly.");
        }
    }
}



