namespace Gussing_game20231
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //These "Random" lines are set up so that every time the game is booted up, it designants a new number at the beginning of every game.
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            //with this integer, we were able to limit the guesses to 3 max.
            int guess;
            int numberOfGuesses = 3;
            bool gameOver = false;

            //Right here, we are asking the user to guess the number.
            Console.WriteLine("Guess my Number, it's somewhere between 1-10");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;


                //These lines are set up to tell user if they've guessed correctly, or lost.
                //Line 29 means that if your guesses are not equal to the randomNumber chosen, it will read as "0 and will fail the game.
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
                //These lines are set up so that if a guess is wrong, they can hint the user on if the answer is Higher or Lower than their innital guess.
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