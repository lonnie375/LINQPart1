using System;
using System.Linq;

namespace LinqLab31numsonly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nums array
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942, };

            //Below are the questions to answer

            //Find the minimum value
            var numsMin = nums.Min();
            Console.WriteLine($"The minimum value is: {numsMin}");

            //Find the maximum value
            var numsMax = nums.Max();
            Console.WriteLine($"The maximum value is: {numsMax}");

            //Find  the Maxium value less than 10,000
            var numsMax10000 = (from x in nums where x < 10000 select x).Max();
            Console.WriteLine($"The maximum value less than 10,0000: {numsMax10000}");

            //Find all values between 10 and 100
            var numRange = nums.Where(x => x > 10 && x < 100).ToList();
            Console.WriteLine(String.Join(",", numRange));

            //Find all the values between 100,000 and 999,999 inclusive
            var numLargeRange = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            Console.WriteLine(String.Join(",", numLargeRange));

            //Count all the even numbers
            var numCount = nums.Count(x => x % 2 == 0);
            Console.WriteLine($"Count of the numbers that are even: {numCount}");

        }
    }
}
