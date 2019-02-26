using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaMenu
{


    class Menu
    {
      

        public static void Main(string[] args)
        {

            DisplayMenu();

        }

        public static void DisplayMenu()
        {
            double TotalCost;
            string MenuChoice;


            Console.WriteLine("Please Select and Option.");
            Console.WriteLine("1. New Order");
            Console.WriteLine("2. Modify Order");
            Console.WriteLine("3. Display Order");
            Console.WriteLine("4. Quit");
            MenuChoice = Console.ReadLine();

            while (true)

            {


                if (MenuChoice == "1")
                {

                    DisplayOrderMenu();
                }
                
                if (MenuChoice == "2")
                {
                    string Choice;
                    Console.WriteLine("Here is your order so far");
                    Console.WriteLine("Size: ");

                    Console.WriteLine("Would you like to change your Order?  Y or N?");
                    Choice = Console.ReadLine();
                    if(Choice == "Y")
                    {
                        DisplayOrderMenu();
                    }
                    if(Choice =="N")
                    {
                        DisplayMenu();
                    }


                }

                if (MenuChoice == "3")
                {
                    Console.WriteLine("Here is your order so far");
                    Console.WriteLine("Size:" );
                    Console.WriteLine("Toppings:");
                    Console.WriteLine("Sauce:");
                    Console.WriteLine("Cheese:");
                    Console.WriteLine("Delivery:");
                    Console.WriteLine("Total Cost:  " );

                    
                }

                if (MenuChoice == "4")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }



                else
                {
                    Console.WriteLine("Please Select a valid option");
                    Console.WriteLine(" ");
                    DisplayMenu();
                }

            }
        }

        public static void DisplayOrderMenu()
        {
            double TotalPrice;
            string Size;
            double SizeCost;
            bool delivery;
            string veggies, sauce, meats;
            Console.WriteLine("Please Select a size S, M, or L");
            Console.WriteLine("Small $5.00");
            Console.WriteLine("Medium $6.25");
            Console.WriteLine("Large $8.75");
            Size = Console.ReadLine();
            if (Size == "S")
            {
                SizeCost = 5.00;
                Size = ("Small");

            }
            else if (Size == "M")
            {
                SizeCost = 6.25;
                Size = ("Medium");


            }
            else if (Size == "L")
            {
                SizeCost = 8.75;
                Size = ("Large");

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
    }


    }



