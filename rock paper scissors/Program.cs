using System;

Console.WriteLine("Rock,Paper,Scissors Enter your choice!");
string playerchoice = Console.ReadLine();

while (playerchoice != "Rock" && playerchoice != "Paper" && playerchoice != "Scissors")
{
    Console.WriteLine("Invalid choice please enter Rock,Paper,Scissors!");
    playerchoice = Console.ReadLine();
}
