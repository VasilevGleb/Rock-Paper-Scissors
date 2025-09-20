using System;

Console.WriteLine("Welcome to the game!");

Console.WriteLine("Choose: Schäre, Stein, Papier");
string yourChoice = Console.ReadLine();

Random action = new Random();
string[] option = { "Schäre", "Stein", "Papier" };
int number = action.Next(0, 3);
string computerChoice = option[number];

string yourChoiceLower = yourChoice.ToLower();
string computerChoiceLower = computerChoice.ToLower();

Console.WriteLine($"Computer chose: {computerChoice}");
if (yourChoiceLower == computerChoiceLower)
{
    Console.WriteLine("It's a tie!");
}
else if ((yourChoiceLower == "schäre" && computerChoiceLower == "papier") ||
                (yourChoiceLower == "stein" && computerChoiceLower == "schäre") ||
                (yourChoiceLower == "papier" && computerChoiceLower == "stein"))
{
    Console.WriteLine("You win!");
}
else if ((yourChoiceLower == "schäre" && computerChoiceLower == "stein") ||
                (yourChoiceLower == "stein" && computerChoiceLower == "papier") ||
                (yourChoiceLower == "papier" && computerChoiceLower == "schäre"))
{
    Console.WriteLine("You lose!");
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}

Console.WriteLine("Thanks for playing. Goodbye!");
Console.WriteLine("Press Enter to exit...");
Console.ReadLine();