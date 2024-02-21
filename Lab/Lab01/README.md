# Lab 01

## Description
This C# program allows users to input a number and then checks whether the number is prime or not. If the number is prime, it displays a message indicating that. Otherwise, it finds and displays the largest factor of the input number.

## Instructions
1. Run the program.
2. Enter a number when prompted.
3. The program will then determine whether the number is prime or not.
4. If the number is prime, it will display a message indicating that.
5. If the number is not prime, it will find and display the largest factor of the input number.

## Usage
```bash
dotnet run
```

## Source Code
```csharp
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
```

## Example
```bash
Enter a number: 27
Largest factor of 27 is: 9
```

Feel free to use this program to check prime numbers or find the largest factor of a number.