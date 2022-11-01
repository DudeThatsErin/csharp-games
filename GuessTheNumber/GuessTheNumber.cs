using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int returnValue = random.Next(1, 100);
            int Guess = 0;

            Console.WriteLine("I am thinking of a number between 1-100. Can you guess what it is?");

            while(Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if(Guess < returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess);
                }
                else if(Guess > returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess);
                }


            }

            Console.WriteLine("Awesome! You got it! The answer was " + returnValue);
            Console.ReadLine();

        }
    }
}
