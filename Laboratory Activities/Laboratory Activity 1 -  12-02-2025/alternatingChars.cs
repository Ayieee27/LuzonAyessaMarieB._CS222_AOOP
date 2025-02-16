using System;

class Program
{
    static void Main()
    {
        Console.Write("First character: ");
        char firstChar = Console.ReadLine()[0];

        Console.Write("Second character: ");
        char secondChar = Console.ReadLine()[0];

        Console.Write("Enter size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("-");
            }

            char currentChar = (i % 2 == 0) ? firstChar : secondChar;
            Console.WriteLine(currentChar);
        }
    }
}