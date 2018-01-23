using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string firstName, lastName, color, vacation, transportation, bankMoney;
            string HELP = "help";
            int age, birthMonth, sibs, yearsToRetire;
            int RETIREAGE = 60;

            //Writes ti consol, Getting user input, convert to uppercase
            Console.WriteLine("Hi, What's your first name?");
            firstName = Console.ReadLine().ToUpper();


            //Writes to console, Get user input convert to all upper case
            Console.WriteLine("\nok!, What's your last name?");
            lastName = Console.ReadLine().ToUpper();


            //Writes to console, Get user input, convert to an integer, assign to age
            Console.WriteLine("\nGreat!, Can you tell me your age?");
            age = int.Parse(Console.ReadLine());


            //Writes to console, Gets user input, converts to interger, assigns to birthMonth
            Console.WriteLine("\nok, what month were you born?");
            birthMonth = int.Parse(Console.ReadLine());


            //Writes to the console, gets user input, assign input to color
            Console.WriteLine("\nWhat's your favorite ROYGBIV color?, or type Help to display menu");
            color = Console.ReadLine().ToLower();


            //if statement that displays help menu when user types help
            if (color == HELP)
            {
                Console.WriteLine("\nROYGBIV represents the colors:\nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet");
                Console.WriteLine("\nPlease select your favorite color from the menu!");
                color = Console.ReadLine().ToLower();
            }


            //Wries to the console, gets user input, converts input to integer, assign input to sibs
            Console.WriteLine("\nHow many siblings do you have?");
            sibs = int.Parse(Console.ReadLine());


            //Calculates the number of years until retirement, assigns value to yearsToRetire
            yearsToRetire = RETIREAGE - age;


            //if statement that assigns different vacation values to vacation based on conditions
            if (sibs == 0)
            {

                vacation = "The Virgin islands";
            }

            else if (sibs == 1)
            {
                vacation = "Hawaii";

            }
            else if (sibs == 2)
            {

                vacation = "Cancun Mexico";
            }

            else if (sibs == 3)
            {
                vacation = "Canada";
            }

            else if (sibs > 3)
            {
                vacation = "Sunny California";

            }
            else
                vacation = "your home town";


            //switch statement that assigns transportation types to transportation based on conditions
            switch (color)
            {
                case "red":
                    transportation = "Plane";
                    break;

                case "orange":
                    transportation = "Private Jet";
                    break;

                case "yellow":
                    transportation = "School Bus";
                    break;

                case "green":
                    transportation = "Pruis";
                    break;

                case "blue":
                    transportation = "Plane";
                    break;

                case "indigo":
                    transportation = "Helicopter";
                    break;

                case "violet":
                    transportation = "Train";
                    break;

                default:
                    transportation = "Car";
                    break;
            }


            //if statement that cheks expressions to determine the amount of my that gets assigned to bankMoney
            if ((birthMonth >= 1) && (birthMonth <= 4))
            {
                bankMoney = "$10000.00";

            }
            else if ((birthMonth >= 5) && (birthMonth <= 8))
            {
                bankMoney = "$9000.00";
            }
            else if ((birthMonth >= 9) && (birthMonth <= 12))
            {
                bankMoney = "$8000.00";
            }
            else
                bankMoney = "$0.00";


            //Writes to the console followed by a new line
            Console.WriteLine("Processing your fortune now>>>> \n");
           

            //writes to console, tells user their future using stored user input values
            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsToRetire + "yrs with " + bankMoney + " in the bank, \na vaction home in " 
                + vacation + " , and a " + transportation +"\n");


           
            

        }
        
    }
}
