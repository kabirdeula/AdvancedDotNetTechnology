using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine(num + " is a prime number.");
        }
        else
        {
            int largestFactor = FindLargestFactor(num);
            Console.WriteLine("Largest factor of " + num + " is: " + largestFactor);
        }
    }

    // Function to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        if (num <= 3)
            return true;
        if (num % 2 == 0 || num % 3 == 0)
            return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }

        return true;
    }

    // Function to find the largest factor of a number
    static int FindLargestFactor(int num)
    {
        int largestFactor = 1;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                largestFactor = i;
        }
        return largestFactor;
    }
}
