# Linear Regression Program

This C# program demonstrates linear regression using a set of data points represented by arrays `xValues` and `yValues`. The program calculates the slope (`m`) and y-intercept (`c`) of the fitted line using the least squares method.

## Instructions
1. Run the program.
2. The program will use the provided data points to calculate the slope and y-intercept of the fitted line.

## Usage
```bash
dotnet run
```

## Output
The program will display the equation of the fitted line in the form `y = mx + c`.

## Source Code

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Example set of points
        double[] xValues = { 1, 2, 3, 4, 5, 6 };
        double[] yValues = { 2, 4, 6, 8, 10, 12 };

        double n = xValues.Length;
        double sumXiYi = 0, sumXi = 0, sumYi = 0, sumXiSquare = 0;

        // Calculate sums
        for (int i = 0; i < n; i++) {
            sumXiYi += xValues[i] * yValues[i];
            sumXi += xValues[i];
            sumYi += yValues[i];
            sumXiSquare += xValues[i] * xValues[i];
        }

        // Calculate slope (m) and y-intercept (c)
        double m = (n * sumXiYi - sumXi * sumYi) / (n * sumXiSquare - sumXi * sumXi);
        double c = (1 / n) * (sumYi - m  * sumXi);

        // Display the Results
        Console.WriteLine($"The equation of the fitted line is: y = {m}x + {c}");
    }
}
```

Feel free to modify the program or integrate it into your project. The source code is well-commented to explain the linear regression calculation steps.