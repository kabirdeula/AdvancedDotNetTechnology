public class Program
{
   public static void Main(string[] args)
    {
        /**
         * Example set of points
         * 
         * Each pair (x_i, y_i) represents a 
         * point in the Cartesian coordinate system.
         */
        double[] xValues = { 1, 2, 3, 4, 5, 6 };
        double[] yValues = { 2, 4, 6, 8, 10, 12 };

        /**
         * Calculate m and c.
         *
         * n is initailized to the length of the arrays.
         * Representing the number of data points.
         * The variables sumXiYi, sumXi, sumYi, and sumXiSquare
         * are initialized to zero; these variables will be used 
         * to accumulate sums during calculations.
         */
        double n = xValues.Length;
        double sumXiYi = 0, sumXi = 0, sumYi = 0, sumXiSquare = 0;


        /**
         * This for loop iterates through each point
         * and calculates the following sums:
         * 
         * sumXiYi: Sum of the product of x and y values.
         * sumXi: Sum of x values.
         * sumYi: Sum of y values.
         * sumXiSquare: Sum of the square of x values.
         */
        for (int i = 0; i < n; i++) {
            sumXiYi += xValues[i] * yValues[i];
            sumXi += xValues[i];
            sumYi += yValues[i];
            sumXiSquare += xValues[i] * xValues[i];
        }

        /**
         * Calculation of Slope (m) and Y-intercept (c)
         */
        double m = (n * sumXiYi - sumXi * sumYi) / (n * sumXiSquare - sumXi * sumXi);
        double c = (1 / n) * (sumYi - m  * sumXi);

        // Display the Results
        Console.WriteLine($"The equation of the fitted line is: y = {m}x + {c}");

    }
}