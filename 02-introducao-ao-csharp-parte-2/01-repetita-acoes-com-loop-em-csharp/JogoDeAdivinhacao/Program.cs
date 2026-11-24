// Set up the game

Random random = new Random();
int secretNumber = random.Next(1, 21);
int maxGuesses = 5;
int guessCount = 0;
bool hasWon = false;

Console.WriteLine("I'm thinking of a number between 1 and 20.");
Console.WriteLine($"You have {maxGuesses} guesses. Good luck!");

// Ask the player to guess

while (guessCount < maxGuesses)
{
    guessCount++;
    Console.Write($"\nGuess #{guessCount}: ");
    int guess;
    while (!int.TryParse(Console.ReadLine(), out guess))
    {
        Console.Write("That is not a valid number. Try again: ");
    }

    // Check the guess and give feedback

    if (guess == secretNumber)
    {
        Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
        hasWon = true;
        break;
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("Too low.");
    }
    else
    {
        Console.WriteLine("Too high.");
    }

    if (Math.Abs((long)guess - secretNumber) <= 2)
    {
        Console.WriteLine("You're very close!");
    }
}

// Announce the result

if (!hasWon)
{
    Console.WriteLine($"\nOut of guesses! The number was {secretNumber}.");
}
