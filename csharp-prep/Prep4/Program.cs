using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int number = 1;
            int sum = 0;

            while (number != 0)
            {
                Console.Write("Enter a number (0 to quit): ");
            
                string userResponse = Console.ReadLine();
                number = int.Parse(userResponse);

                if (number != 0)
                {
                    numbers.Add(number);
                } else {
                    foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Count;

            int max = int.MinValue;
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            }
        }    
    }
}
            