// github.com/fxward cs
// EvenOrOdd
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Made by github.com/fxward");
        Console.Write("Type a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("\nNumber is Even");
        }
        else 
        {
            Console.WriteLine("Number is Odd");
        }
    }
}