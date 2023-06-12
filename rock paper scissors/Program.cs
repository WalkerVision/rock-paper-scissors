using System;

class Program
{

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Rock,Paper,Scissors Enter your choice!");
            string userChoice = Console.ReadLine();

            // added a chioce validation with a while loop
            while (userChoice != "Rock" && userChoice != "Paper" && userChoice != "Scissors")
            {
                Console.WriteLine("Invalid choice please enter Rock,Paper,Scissors!");
                userChoice = Console.ReadLine();
            }

            //generate computer's choice
            Random random = new Random();
            string[] choices = { "Rock", "Paper", "Scissors" };
            int computerChoiceIndex = random.Next(0, 3);
            string computerChoice = choices[computerChoiceIndex];

            //string userChoice = playerchoice;
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

            //ask player if they want to play again
            Console.WriteLine("Would you like to play again? Y/N ");
            string playAgainInput = Console.ReadLine();

            if (playAgainInput.ToUpper() != "Y")
            {
                break;
            }
            
         

        }
            // wait for user input to exit
            Console.WriteLine("Thanks for playing");
            Console.WriteLine("Press return key to exit...");
            Console.ReadLine();


    }
}
