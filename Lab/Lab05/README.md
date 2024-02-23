# Lab 01 - Exception Handling

## Description
This C# program takes two integer inputs, performs a division operation, and displays the result. The program includes error handling using a try-catch block to handle potential exceptions, such as division by zero or invalid input.

## Instructions
1. Run the program.
2. Enter an integer for "Number 1" when prompted.
3. Enter another integer for "Number 2" when prompted.
4. The program will attempt to perform the division operation (Number 1 / Number 2).
5. If successful, it will display the result.
6. If an exception occurs during the execution, error details will be printed, including the exception message, source, stack trace, and help link.

## Usage
```bash
dotnet run
```

## Input
- Enter an integer for "Number 1" when prompted.
- Enter another integer for "Number 2" when prompted.

## Output
- If successful, the program will display the result of the division.
- If an exception occurs, error details will be printed.

## Error Handling
The program includes exception handling to deal with potential issues during execution. The following information will be displayed if an exception occurs:
- Exception Message
- Exception Source
- Stack Trace
- Help Link (if available)

## Source Code

```csharp
class Program
{
    static void Main(string[] args)
    {
        int num1, num2, result;
        try
        {
            Console.Write("Number 1: ");
            num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Number 2: ");
            num2 = int.Parse(Console.ReadLine()!);

            result = num1 / num2;

            Console.WriteLine($"Result of {num1} and {num2} is {result}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Source: {ex.Source}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");
            Console.WriteLine($"HelpLink: {ex.HelpLink}");
        }

    }
}
```

## Example
Success Example
```bash
Number 1: 10
Number 2: 2
Result of 10 and 2 is 5
```
Exception Example
```bash
Number 1: 20
Number 2: 0
Message: Attempted to divide by zero.
Source: Lab01
StackTrace:    at Program.Main(String[] args) in C:\Lab01\Program.cs:line 13
HelpLink:

C:\Lab01\bin\Debug\net7.0\Lab01.exe (process 8996) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
```

## Note
Ensure that valid integer inputs are provided to avoid potential exceptions, such as division by zero or invalid input.

Feel free to modify and enhance the program as needed.