Random dice = new Random();
int rounds;

// Ask for a positive number of rounds
Console.Write("How many rounds do you want to play? ");
string? input = Console.ReadLine();
while (!int.TryParse(input, out rounds) || rounds <= 0)
{
    if (input == null)
    {
        return;
    }

    Console.Write("Enter a positive whole number: ");
    input = Console.ReadLine();
}

int bonusCount = 0;

for (int round = 0; round < rounds; round++)
{
    // Roll three 20-sided dice
    int roll1 = dice.Next(1, 21);
    int roll2 = dice.Next(1, 21);
    int roll3 = dice.Next(1, 21);
    int total = roll1 + roll2 + roll3;

    Console.WriteLine($"\nRound {round + 1}: {roll1} + {roll2} + {roll3} = {total}");

    // Count a bonus once per round, whether doubles or triples
    if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    {
        bonusCount += 1;

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }
        else
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }
    }

    Console.WriteLine($"Final total: {total}");

    // Award a prize using the original thresholds
    if (total >= 16)
    {
        Console.WriteLine("You win a new car!");
    }
    else if (total >= 10)
    {
        Console.WriteLine("You win a new laptop!");
    }
    else if (total == 7)
    {
        Console.WriteLine("You win a trip for two!");
    }
    else
    {
        Console.WriteLine("You win a kitten!");
    }
}

Console.WriteLine($"\nYou rolled a bonus in {bonusCount} of {rounds} round(s).");
