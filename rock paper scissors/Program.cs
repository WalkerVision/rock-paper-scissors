using System;

class Program
{
    static string[] choices = { "Rock", "Paper", "Scissors" };
    static void Main(string[] args)
    {

        Console.WriteLine("Rock,Paper,Scissors Enter your choice!");
        string playerchoice = Console.ReadLine();

        // added a chioce validation with a while loop
        while (playerchoice != "Rock" && playerchoice != "Paper" && playerchoice != "Scissors")
        {
            Console.WriteLine("Invalid choice please enter Rock,Paper,Scissors!");
            playerchoice = Console.ReadLine();
        }
        //while (true)
        //generate computer's choice
        Random random = new Random();
        string[] choices = { "Rock", "Paper", "Scissors" };

        int computerChoiceIndex = random.Next(0, 3);
        string computerChoice = choices[computerChoiceIndex];

        string userChoice = playerchoice;
        string result;

        if (userChoice == computerChoice)
        {
            result = "It's a tie!";
        }
        else if ((userChoice == "Rock" && computerChoice == "Scissors") || (userChoice == "Paper" && computerChoice == "Rock") || (userChoice == "Scissors" && computerChoice == "Paper"))
        {
            result = "You Win";
        }
        else
        {
            result = "Computer wins!";
        }

        // display result
        Console.WriteLine($"your choice: {userChoice}");
        Console.WriteLine($"computer's choice: {computerChoice}");
        Console.WriteLine(result);

        // wait for user input to exit
        Console.WriteLine("Press agin key to exit...");
        Console.ReadLine();



    }

}

