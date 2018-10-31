/*Garding ID: A4431
 * Program 1
 * Due Date: 09-26-2017
 * Course Section: 01
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {

            double lengthOfWalls, heightOfWalls, minGallons;    
            /*lengthOfWalls represents the perimeter of the room in feet. 
             * heightOfWalls represents the height of the walls in the room in feet. 
             * minGallons represents the minimum gallons of paint needed for the room. */

            const double PAINT_CANS = 350;//the constant for how much square feet each can of paint can cover

            const int NUMBER_OF_DOORS = 20, NUMBER_OF_WINDOWS = 15;//the constant for how much square feet each door and window

            int numberOfCoats, numberOfDoors, numberOfWindows;
            /*numberOfCoats is the number of coats of paint to be used.
             * numberOfDoors is the total number of doors in the room..
             * numberOfWindows is the total number of windows in the room.*/

            float gallonsToBuy;//This will be the whole number of paint cans to buy to completely paint the room.

            string userInputLenght, userInputHeight, userInputDoors, userInputWindows, userInputCoatsOfPaint;/*These will represent what the user inputs for the length, height, doors, 
                                                                                                                   windows, and coats of paint for the room.*/

            WriteLine("Welcome to the Handy-Dandy Paint Estimator");
            WriteLine();
            Write("Enter the total length of all walls (in feet):  ");
            userInputLenght = $"{ ReadLine():D}";
            Write("Enter the height of the walls (in feet):  ");
            userInputHeight = $"{ReadLine():D}";
            Write("Enter the number of doors (non-neg int):   ");
            userInputDoors = $"{ReadLine():I}";
            Write("Enter the number of windows (non-neg int): ");
            userInputWindows = $"{ReadLine():I}";
            Write("Enter the number of coast of paint (non-neg int):  ");
            userInputCoatsOfPaint = $"{ReadLine():I}";

            lengthOfWalls = double.Parse(userInputLenght);//converts the user's input of the perimeter to a double
            heightOfWalls = double.Parse(userInputHeight);//converts user's input of total wall height to a double
            numberOfDoors = int.Parse(userInputDoors);//converts the user's input of total number of doors to a integer
            numberOfWindows = int.Parse(userInputWindows);//converts the user's input of total number of windows to an integer
            numberOfCoats = int.Parse(userInputCoatsOfPaint);//converts the user's input of total desired paint coats to an integer

            minGallons = (((lengthOfWalls * heightOfWalls) - ((numberOfDoors*NUMBER_OF_DOORS)+(numberOfWindows*NUMBER_OF_WINDOWS)))*numberOfCoats)/PAINT_CANS;//calculates the gallons of paint to buy
            {
                gallonsToBuy = (int)Math.Ceiling(minGallons);//determines the minimum gallons of paint to buy
                WriteLine();
                WriteLine($"You'll need a minimum of {minGallons:F1} gallons of paint");
               WriteLine($"You'll need to buy {gallonsToBuy} gallons, though");
            }
        }
    }
}
