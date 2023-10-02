using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 2 == 0)
            Console.WriteLine("The number is even");
        else
            Console.WriteLine("The number is odd");
    }

}