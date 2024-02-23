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
