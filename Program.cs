using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("======== Input Odds Program ========");
        InputNumberRoom();
    }

    public static void InputNumberRoom()
    {
        int num1, num2;

        // NUM  1
        while (true)
        {
            Console.Write("Please keyboard input number 1: ");
            if (int.TryParse(Console.ReadLine(), out num1))
                break;

            Console.WriteLine("Invalid input! Please enter a number.");
        }

        // NUM  2
        while (true)
        {
            Console.Write("Please keyboard input number 2: ");
            if (int.TryParse(Console.ReadLine(), out num2))
                break;

            Console.WriteLine(" Invalid input! Please enter a number.");
        }

        if (num1 == num2)
        {
            Console.WriteLine($"Numbers are equal. Num1: {num1}, Num2: {num2}");
        }
        else if (num1 > num2)
        {
            Console.WriteLine($"Number 1: {num1} is greater than Number 2: {num2}");
        }
        else
        {
            Console.WriteLine($"Number 2: {num2} is greater than Number 1: {num1}");
        }

        Console.ReadKey();
    }
}
