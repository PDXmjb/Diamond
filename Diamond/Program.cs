using System;
using System.Text;

public class Diamond
{
    public static string print(int n)
    {
        // If even, zero, or negative, return null.
        if (n % 2 == 0 || n < 0)
        {
            return null;
        }

        var diamond = new StringBuilder();
        var center = n / 2 + 1;

        // To simplify later math, using a starting index of 1.
        for (int i = 1; i <= n; i++)
        {
            var line = "";

            // Calculating how far from the middle of the diamond we are.
            var distanceFromCenter = Math.Abs(center - i);

            // We need to have the number of spaces be the same as how far we are from the middle,
            // e.g., if we're 2 away from center, we need two spaces.
            for (int j = 0; j < distanceFromCenter; j++)
            {
                line += " ";
            }

            // The number of stars is equal to the size of the diamond, minus 2(distance from center)
            // e.g., size = 5, # of stars = 5 - (2 * 2) = 1 for the first row.
            for (int k = 0; k < (n - (distanceFromCenter * 2)); k++)
            {
                line += "*";
            }

            diamond.Append(line + "\n");
        }

        return diamond.ToString();
    }
}