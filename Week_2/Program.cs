using System;

namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have in professional programming?");
            string input = Console.ReadLine();
            int xp = int.Parse(input);
            int i = 0;

            while ((i >= 0) && (i <= xp))
            {
                Console.WriteLine("You have " + i + "years of experience");
                i = i + 1;
            }

        }
    }
}
