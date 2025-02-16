using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            // For the row to be skipped, print empty line
            if (i == y)
            {
                Console.WriteLine();
                continue;
            }

            for (int j = 1; j <= n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }
}