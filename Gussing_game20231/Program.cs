namespace Gussing_game20231
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int guess;
            int numberOfGuesses = 3;
            bool gameOver = false;

            Console.WriteLine("Guess my Number, it's somewhere between 1-10");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;

                if (guess != randomNumber && numberOfGuesses == 0)
                {
                    Console.WriteLine("I see you couldn't figure it out. Go back to school (Maniacal laugh)");
                    gameOver = true;
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("That's Correct! look at you Mrs/Mr.SmartyPants.");
                    gameOver = true;
                }
                else
                {
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("It's lower than that, buddy.");
                    }
                        
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Sorry, you wanna go higher.");
                    }

                }

            }




        }
    }
}


//string boogers





/* int correctAnswers = 0;
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


            // Ask the user 10 questions about R&B artists.
            //this code for the "questions" not points.
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
                    correctAnswers++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! The correct answer is " + answers[i]);
                }
            }

            // Tell the user the number of questions they answered correctly.
            Console.WriteLine("You answered " + correctAnswers + " questions correctly.");
        }*/