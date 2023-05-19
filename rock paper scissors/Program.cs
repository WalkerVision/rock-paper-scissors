using System;

class Program
{
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

        //generate computer's choice
        Ramdom ramdom = new Ramdom();
        string[] choices = { "Rock, Paper, Scissors" };
        string computerchoice = choices[ramdom.Next(choices.Length)];

        string userChoice = playerchoice;
        string result;

        if (userChoice == playerchoice)
        {
            result = "It's a tie!";
        }
        else if ((userChoice == "Rock" && computerchoice == "Scissors") || (userChoice == "Paper" && computerchoice == "Rock") || (userChoice == "Scissors" && computerchoice == "Paper"))
        {
            result = "You Win";
        }
        else
        {
            result = "Computer wins!";
        }




    }

}

