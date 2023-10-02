using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        int operand1 = 100;
        int operand2 = 0;
        Console.Write("Please enter your sign: ");
        string sign = Console.ReadLine();

        switch (sign)
        {
            case "+":
                Console.Write(operand1 + operand2);
                break;

            case "-":
                Console.Write(operand1 - operand2);
                break;

            case "*":
                Console.Write(operand1 * operand2);
                break;

            case "/":
                if (operand1 == 0)
                {
                    Console.WriteLine("Attempt to divide by zero");
                }
                else if (operand2 == 0)
                {
                    Console.WriteLine("Attempt to divide by zero");
                }
                else
                {
                    Console.Write(operand1 / operand2);
                }
                break;
        }
    }
}
