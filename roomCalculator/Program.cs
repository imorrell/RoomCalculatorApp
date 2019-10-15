/*Program: Room Calculator
  Programmer: Ivoire Morrell
  Date: October 14th, 2019
  Description: This program is used to determine the 
  area, perimeter, and volume given the user entered input.
 */


using System;

namespace roomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //intilize varibles that will store user input
            double length;
            double width;
            double height;
            double perimeter;
            double area;
            double volume;

            //use bool variable to determine if user wants to continue
            bool ok = true;

            //create a while loop to determine if the user wants to continue entering measurements
            while (ok)
            {
                //welcome the user to the room calculator program
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator! \n");

                //prompt user to enter the length
                Console.WriteLine("Enter length: \n");

                //enter length
                length = double.Parse(Console.ReadLine());

                Console.WriteLine();

                //prompt user to width
                Console.WriteLine("Enter width: \n");

                //enter width
                width = double.Parse(Console.ReadLine());

                Console.WriteLine();

                //prompt the user to enter height
                Console.WriteLine("Enter height: \n");

                //enter the height
                height = double.Parse(Console.ReadLine());

                Console.WriteLine();

                //call the roomPerimeter method
                perimeter = roomPerimeter(length, width);

                //call the roomArea method
                area = roomArea(length, width);

                //calculate the volume
                volume = roomVolume(length, width, height);

                //display the perimeter, area, and volume
                Console.WriteLine("Perimeter: " + perimeter + "\n");

                Console.WriteLine("Area: " + area + "\n");

                Console.WriteLine("Volume: " + volume + "\n");

                //Determine if user wants to go again
                ok = getContinue();

                Console.WriteLine();
            }
           
        }

        // The roomPerimeter function is used to calculate the perimeter of the room
        private static double roomPerimeter(double length, double width)
        {
            //intialize variables
            double perimeter;

            //calculate the perimeter
            perimeter = (length * 2) + (width * 2);

            //return perimeter
            return perimeter;
        }

        // The roomArea function is used to calculate the perimeter of the room
        private static double roomArea(double length, double width)
        {
            //intialize variables
            double area;

            //calculate the area
            area = length * width;

            //return area
            return area;
        }

        // The roomVolume function is used to calculate the perimeter of the room
        private static double roomVolume(double length, double width, double height)
        {
            //intialize variables
            double volume;

            //calculate the volume
            volume = length * width * height;

            //return volume
            return volume;
        }

        //this method is used to determine if the user wants to continue within a loop
        public static bool getContinue()
        {
            //create variables
            String choice;
            bool ok = true;
            bool result = true;

            //create while loop to determine if user wants to continue
            while (ok)
            {
                Console.WriteLine("Continue? (y/n):");

                //retrieve user input
                choice = Console.ReadLine();

                //determine the users input and return corresponding message
                if (choice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    //user wants to continue. exit the while loop and return true
                    ok = false;
                    result = true;
                }
                else if (choice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    //user does not want to continue
                    ok = false;
                    result = false;
                }
                else
                {
                    //user did not enter y or n
                    Console.WriteLine("Error! Please enter Y or N. Please enter correct input");

                }

            }

            return result;
        }

    }
}
