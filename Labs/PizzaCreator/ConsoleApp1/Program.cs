using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMenu
{
  
    class Menu

    {
        
       
        static void Main(string[] args)
        {
            double TotalCost;
            double SizeCost;
            string veggies, sauce, meats;
            bool delivery;
            string size;
            string MenuChoice;
            
            Console.WriteLine("Please Select and Option." );
            Console.WriteLine("1. New Order");
            Console.WriteLine("2. Modify Order");
            Console.WriteLine("3. Display Order");
            Console.WriteLine("4. Quit");
            MenuChoice = Console.ReadLine();
            
       
            if  (MenuChoice == "1")
            {
                double TotalPrice;
                Console.WriteLine("Please Select a size S, M, or L");
                Console.WriteLine("Small $5.00");
                Console.WriteLine("Medium $6.25");
                Console.WriteLine("Large $8.75");
                size = Console.ReadLine();
                if (size == "S")
                {
                    SizeCost = 5.00;
                   
                }
                else if (size == "M")
                {
                    SizeCost = 6.25;
                  

                }
               else if (size == "L")
                {
                    SizeCost = 8.75;
                    
                }
                
                
                Console.WriteLine("Please enter the number for your toppings");
                Console.WriteLine("Meats +$.075 each");
                Console.WriteLine("1 Bacon");
                Console.WriteLine("2 Ham");
                Console.WriteLine("3 Pepperoni");
                Console.WriteLine("4 Sausage");
                Console.WriteLine("Veggies + $.50 each");
                Console.WriteLine("5 Olives");
                Console.WriteLine("6 Mushrooms");
                Console.WriteLine("7 Onions");
                Console.WriteLine("8 Peppers");
                Console.ReadLine();

                Console.WriteLine("What Sauce would you like?");
                Console.WriteLine("Traditional $0");
                Console.WriteLine("Garlic + $1");
                Console.WriteLine("Oregano + $1");

                Console.WriteLine("Would you like extra Cheese? Y or N");

                Console.WriteLine("Would you like this Delivered?");







            }

            if (MenuChoice == "2")
            {
                Console.WriteLine("Would you like to change your Pizza Size Y or N?");

            }

            if (MenuChoice == "3")
            {
                Console.WriteLine("Here is your order so far");
            }

            if (MenuChoice == "4")
            {
                Console.WriteLine("Goodbye");
            }

                    
        }


        

            

    
    
}

    
}

