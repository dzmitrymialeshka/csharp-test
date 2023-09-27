using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int userInput = int.Parse(Console.ReadLine());

        string rangeName;

        if (userInput >= 0 && userInput <= 14)
        {
            rangeName = "0 - 14";
        }
        else if (userInput >= 15 && userInput <= 35)
        {
            rangeName = "15 - 35";
        }
        else if (userInput >= 36 && userInput <= 50)
        {
            rangeName = "36 - 50";
        }
        else if (userInput >= 51 && userInput <= 100)
        {
            rangeName = "51 - 100";
        }
        else
        {
            rangeName = "outside of the specified ranges";
        }

        Console.WriteLine($"The number is in range {rangeName}");
    }
}
