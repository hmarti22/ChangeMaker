using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change_maker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);
  
            Console.ReadKey();
        }
        //creating the function for changemaker
        static void ChangeMaker(double amount)
        {
            //declaring variables for the number of coins
            double i = amount;
            
            int hundreds = 0;
          
            int fiftys = 0;
            
            int twentys = 0;
            
            int tens = 0;
            
            int fives = 0;
           
            int ones = 0;
            
            int quarters = 0;
           
            int dimes = 0;
            
            int nickels = 0;
           
            int pennys = 0;

            //if i is grater than 100 add 100 dollars
            while (i > 100)
            {
             //amount minus 100 untill it is false
                i = i - 100;
            //aone hundred added
                //same follows below with values changeing 
                hundreds++;
            }
           
            while (i > 50)
            {                
                i = i - 50;               
                fiftys++;
            }
             
            while (i > 20)
            {               
                i = i - 20;               
                twentys++;
            }
            
            while (i > 10)
            {              
                i = i - 10;                
                tens++;
            }
          
            while (i > 5)
            {                
                i = i - 5;                
                fives++;
            }
            
            while (i > 1)
            {                
                i = i - 1;                
                ones++;
            }
            
            while (i > .25)
            {                
                i = i - .25;                
                quarters++;
            }
            
            while (i > .10)
            {                
                i = i - .10;                
                dimes++;
            }
            
            while (i > .05)
            {         
                i = i - .05;        
                nickels++;
            }
            
            while (Math.Round(i, 2) > .00)
            {                
                i = i - .01d;                
                pennys++;
            }

            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Hundreds: " + hundreds);
            Console.WriteLine("Fifties: " + fiftys);
            Console.WriteLine("Twenties: " + twentys);
            Console.WriteLine("Tens: " + tens);
            Console.WriteLine("Fives: " + fives);
            Console.WriteLine("Ones: " + ones);
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickels: " + nickels);
            Console.WriteLine("Pennies: " + pennys);
            Console.WriteLine();
        }
    }
}
