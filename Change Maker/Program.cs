using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call for the function Change Maker 
            //with the parameter of 3.18
            ChangeMaker(3.18);
            //Call for the function Change Maker 
            //with the parameter of 0.99
            ChangeMaker(0.99);
            //Call for the function Change Maker 
            //with the parameter 12.93
            ChangeMaker(12.93);
            //Extra Credit
            ChangeMaker(4985.49);
      
            //keeps the console open
            Console.ReadKey();
        }
        //Creating the function for Change Maker
        static void ChangeMaker(double amount)
        {
            //Declaring variables for # of coins
            double i = amount;
            int hundred = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            int quarter = 0;
            int dime = 0;
            int nickel = 0;
            int penny = 0;
            while (i > 100)
            {
                i = i - 100;
                hundred++;
            }
            while (i > 50)
            {
                i = i - 50;
                fifty++;
            }
            while (i > 20)
	        {
                i = i - 20;
                twenty++;
	        }
            while (i > 10)
            {
                i = i - 10;
                ten++;
            }
            while (i > 5)
            {
                i = i - 5;
                five++;
            }
            while (i > 1)
            {
                i = i - 1;
                one++;
            }
            //Creating the while loop for 
            //getting quarters out of our amount
            while (i > 0.25)
            {
                //Takes the total amount and subtracts 
                //the number of quarters out of it
                i = i - 0.25;
                //Adds the number of quarters
                quarter++;
            }
            //Creating the while loop for 
            //getting dimes out of our amount
            while (i > 0.1)
            {
                //Takes the total amount and subtracts
                //the number of dimes out of it
                i = i - 0.1;
                //Adds the number of dimes
                dime++;
            }
            //Creating the while loop for 
            //getting nickels out of our amount
            while (i > 0.05)
            {
                //Takes the total amount and subtracts
                //the number of dimes out of it
                i = i - 0.05;
                //Adds the number of nickels
                nickel++;
            }
            //Creating the while loop for 
            //getting pennies out of out amount
            //with rounding our pennies to 2 decimal places
            while (Math.Round(i,2) > 0.00)
            {
                //Takes the total amount and subtracts
                //the number of pennies out of it
                i = i - 0.01;
                //Adds the number of pennies
                penny++;
            }
            //Printing to the console
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Hundreds: " + hundred);
            Console.WriteLine("Fifties: " + fifty);
            Console.WriteLine("Twenties: " + twenty);
            Console.WriteLine("Tens: " + ten);
            Console.WriteLine("Fives: " + five);
            Console.WriteLine("Ones: " + one);
            Console.WriteLine("Quarters: " + quarter);
            Console.WriteLine("Dimes: " + dime);
            Console.WriteLine("Nickles: " + nickel);
            Console.WriteLine("Pennies: " + penny);
            Console.WriteLine();
        }
    }
}
