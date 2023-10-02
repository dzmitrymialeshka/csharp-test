using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int remainder;
        Math.DivRem(number, 2, out remainder);

        if (remainder == 0)
            Console.WriteLine($"{number} is even.");
        else
            Console.WriteLine($"{number} is odd.");
    }
}
