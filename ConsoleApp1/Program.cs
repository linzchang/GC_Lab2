using System;

namespace ConsoleApp1
{
    class GrandCircusChallenge1
    {
        static void Main()
        {
            //welcome
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            bool keepGoing = true;

            while (keepGoing)
            {
                //prompt user to enter length and width
                Console.WriteLine("Enter Length: ");
                string userLength = Console.ReadLine();
                double Length = double.Parse(userLength);

                Console.WriteLine("Enter Width: ");
                string userWidth = Console.ReadLine();
                double Width = double.Parse(userWidth);

                //display area and perimeter
                Console.WriteLine("Area: " + Length * Width);
                Console.WriteLine("Perimeter: " + ((Width * 2) + (Length * 2)) );

                //prompt user if they would like to continue
                Console.WriteLine("Continue? (y/n)");
                string userInput = Console.ReadLine();
                    if (userInput == "n")
                    {
                        keepGoing = false;
                    }

            } 
        }
    }
}
