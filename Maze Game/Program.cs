using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are starting the maze game! In this game you will be trying to get through the maze.\n");
            Console.WriteLine("You start off at the beginning of the maze. You can go right or left. Which do you choose?");
            string answer = Console.ReadLine();
            if(answer == "left" || answer == "Left" || answer == "LEFT")
            {
                Console.WriteLine("You head left. How many steps do you want to take? You can go up to 20 steps.");
                int steps = Convert.ToInt32(Console.ReadLine());
                if(steps == 0)
                {
                    Console.WriteLine("You have to enter a number greater than 0. So, let's try that again. How many steps do you want to take?");
                }
                else if (steps > 20)
                {
                    Console.WriteLine("That is too far. You can't go farther than 20 steps. Please enter a number greater than 0 and less than 20.");
                }
                else if(steps < 10)
                {
                    Console.WriteLine("You went " + steps + " steps. You see that you can make another left. Do you want to make it?");
                    if(answer == "yes" || answer == "Yes" || answer == "YES")
                    {
                        Console.WriteLine("You make the left. It looks like you can only go straight until you make it to a 4 cross intersection that looks like a + sign. Which direction would you like to go now?");
                        if(answer == "straight" || answer == "Straight" || answer == "forward" || answer == "Forward" || answer == "STRAIGHT" || answer == "FORWARD")
                        {
                            Console.WriteLine("You go straight. How many steps do you want to take? You can take a maximum of 50 steps.");
                            if(steps < 10)
                            {
                                Console.WriteLine("You went " + steps + " steps. You see that you have to make a right and have to go another 100 steps. Once you do that, you make it out of the maze!");
                            }
                        }
                    }
                }
                else if(steps > 10 && steps < 20)
                {
                    Console.WriteLine("You went " + steps + " steps. You see that you can make a right or keep going straight. What would you like to do?");
                    if(answer == "straight" || answer == "keep going" || answer == "forward")
                    {
                        Console.WriteLine("You made it to a dead end! Oh no. You turn around and go back. Do you keep going back the way you came or do you turn left?");
                        if(answer == "keep going" || answer == "straight")
                        {
                            Console.WriteLine("You are back to the start. Let's restart the program.");
                            // SEE HOW TO RESTART AN APPLICATION.
                        }
                    }
                }
            } else if(answer == "right" || answer == "Right" || answer == "RIGHT")
            {
                Console.WriteLine("You head right. How many steps do you want to take? You can go up to 200 steps.");
            }

            Console.WriteLine("Congrats! You beat the game!");
            Console.ReadLine();
        }
    }
}
