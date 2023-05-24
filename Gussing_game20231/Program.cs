namespace Gussing_game20231
{
    internal class Program
    {
        

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

            // Create a list of answers to the questions.
            List<string> answers = new List<string> {
            "Aaliyah Dana Haughton",
            "Beyoncé Giselle Knowles-Carter",
            "Christopher Maurice Brown",
            "Erica Abi Wright",
            "Elgin Baylor Lumpkin III",
            "Gabi Wilson",
            "Jazmine Marie Sullivan",
            "Kanye Omari West",
            "Mary Jane Blige",
            "Abel Tesfaye"
        };

            // Shuffle the list of R&B artists.
            var random = new Random();
            //random.Shuffle(rnBArtists);

            // Ask the user 10 questions about R&B artists.
            for (int i = 0; i < 10; i++)
            {
                // Get the current R&B artist.
                string currentArtist = rnBArtists[i];

                // Ask the user a question about the current R&B artist.
                Console.WriteLine("What is the real name of " + currentArtist + "?");
                string userAnswer = Console.ReadLine();

                // Check if the user's answer is correct.
                bool isCorrect = userAnswer == answers[i];

                if (isCorrect)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! The correct answer is " + answers[i]);
                }
            }

            // Tell the user the number of questions they answered correctly.
            Console.WriteLine("You answered " + (10 - i) + " questions correctly.");
        }
    }
}
}


//string boogers
