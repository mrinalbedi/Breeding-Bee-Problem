using System;
using System.Collections.Generic;

namespace BreedingBeesProblem
{
    public class BeeCalculator
    {
        public int? GetAnswer(int? from, int? to)
        {
            KeyValuePair<int?, int?> Source = Calc(from);
            KeyValuePair<int?, int?> Destination = Calc(to);
            int? x = Source.Key - Destination.Key;
            int? y = Source.Value - Destination.Value;

            decimal _x = (decimal)x;
            decimal _y = (decimal)y;

            //this is the formula that calculates the distance between 2 coordinate points taken from https://www.redblobgames.com/grids/hexagons/#distances
            return (int?)((x * y <= 0) ? Math.Max(Math.Abs(_x), Math.Abs(_y)) : Math.Abs(_x + _y));
        }

        private KeyValuePair<int?, int?> Calc(int? a)
        {
            if (a == 1)
            {
                return new KeyValuePair<int?, int?>(0, 0);
            }
            int? x;
            int? y;
            int? n = 0;
            // the equation (3  * n * (n - 1) + 1) gives us the maximum number of a "level" of the spiral where "n" is the current "level" on the spiral. http://oeis.org/A003215
            // E.G. for level 1 the max number is 1, for layer 2 the max number is 7, for layer 3 the max number is 19, etc. 
            // looping through max numbers of levels until the max number of the layer in less than the entered number will tell us what level the entered number is currently on
            while (3 * n * (n - 1) + 1 < a)
                n++;
            // we subtract one from the current layer to "go back" one level
            //// then we calculate the max number of that level
            //// then subtract the max number of that level from the entered number 
            // the result is the the number of possible coordinate locations of the entered number
            // For example: The user enters '10. It is on level 3, the max number on the level below is 7. Therefore the label position on the level is 3. 
            n--;
            a -= 3 * n * (n - 1) + 1;

            // these conditional statements locate the coordinate based on their position on the spiral and convert the entered number into x,y coordinates using the level and position number

            if (a > 5 * n)
            {
                x = n;
                y = -6 * n + a;
            }

            else if (a > 4 * n)
            {
                x = -4 * n + a;
                y = -n;
            }

            else if (a > 3 * n)
            {
                x = -4 * n + a;
                y = 3 * n - a;
            }

            else if (a > 2 * n)
            {
                x = -n;
                y = 3 * n - a;
            }

            else if (a > n)
            {
                x = n - a;
                y = n;
            }

            else
            {
                x = n - a;
                y = a;
            }

            return new KeyValuePair<int?, int?>(x, y);
        }
    }
}

