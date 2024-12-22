namespace rock_paper_scissors_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            string[] choices = { "rock", "paper", "scissors" };
            Random random = new Random();

            while (true)
            {
                Console.Write("Enter your choice (rock, paper, scissors or 'exit' to quit): ");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "exit")
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    break;
                }

                if (Array.Exists(choices, element => element == userChoice))
                {
                    int computerIndex = random.Next(choices.Length);
                    string computerChoice = choices[computerIndex];

                    Console.WriteLine($"Computer chose: {computerChoice}");

                    if (userChoice == computerChoice)
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    else if ((userChoice == "rock" && computerChoice == "scissors") ||
                             (userChoice == "scissors" && computerChoice == "paper") ||
                             (userChoice == "paper" && computerChoice == "rock"))
                    {
                        Console.WriteLine("You win!");
                    }

                    else if ((userChoice == "rock" && computerChoice == "paper") ||
                            (userChoice == "scissors" && computerChoice == "rock") ||
                            (userChoice == "paper" && computerChoice == "scissors"))
                    {
                        Console.WriteLine("You lose!");
                    }

                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'rock', 'paper', or 'scissors'.");
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}

    