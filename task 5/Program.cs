using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introductory Statement with menu
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~ WELCOME TO THE RESTAURENT! ~");
            Console.WriteLine("==============================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    M   M EEEEE N   N U   U");
            Console.WriteLine("    MM MM E     NN  N U   U");
            Console.WriteLine("    M M M EEEEE N N N U   U");
            Console.WriteLine("    M   M E     N  NN U   U");
            Console.WriteLine("    M   M EEEEE N   N  UUU \n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("==============================");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Burger            - $6.45");
            Console.WriteLine("2. Pizza             - $9.99");
            Console.WriteLine("3. Salad             - $4.99");
            Console.WriteLine("4. French Fries      - $5.45");
            Console.WriteLine("5. Beef Sausage      - $9.20");
            Console.WriteLine("6. Soda              - $2.25");
            Console.WriteLine("7. Exit");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("==============================\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            double burgerPrice = 6.45;
            double pizzaPrice = 9.99;
            double saladPrice = 4.99;
            double frenchFriesPrice = 5.45;
            double beefSausagePrice = 9.20;
            double sodaPrice = 2.25;

            double total = 0;

            // Placing of order
            while (true)
            {
                byte order;
                Console.Write("What would you like to order: ");
                order = Convert.ToByte(Console.ReadLine());


                switch (order)
                {
                    case 1:
                        {
                            total += burgerPrice;
                            Console.WriteLine($"You have ordered a \'Burger\'.\nYour current total is: ${total}\n");
                        }
                        break;
                    case 2:
                        {
                            total += pizzaPrice;
                            Console.WriteLine($"You have ordered a \'Pizza\'.\nYour current total is: ${total}\n");
                        }
                        break;
                    case 3:
                        {
                            total += saladPrice;
                            Console.WriteLine($"You have ordered a \'Salad\'.\nYour current total is: ${total}\n");
                        }
                        break;
                    case 4:
                        {
                            total += frenchFriesPrice;
                            Console.WriteLine($"You have ordered a \'French Fries\'.\nYour current total is: ${total}\n");
                        }
                        break;
                    case 5:
                        {
                            total += beefSausagePrice;
                            Console.WriteLine($"You have ordered a \'Beef Sausage\'.\nYour current total is: ${total}\n");
                        }
                        break;
                    case 6:
                        {
                            total += sodaPrice;
                            Console.WriteLine($"You have ordered a \'Soda\'.\nYour current total is: ${total}\n");
                        }
                        break;
                    case 7:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Thank you for your order!\nYour total bill is: ${0}\n", total);

                            // Calculating the tip amount
                            Console.WriteLine("How much tip would you like to leave? (Enter percentage, e.g., 15): ");
                            double tipPercentage = Convert.ToDouble(Console.ReadLine());
                            if (tipPercentage >= 0)
                            {
                                double tip;
                                tip = total * (tipPercentage / 100);
                                double finalTotal = total + tip;
                                Console.WriteLine($"You left a {tipPercentage}% tip.\nTip amount: ${tip}");
                                Console.WriteLine($"Final total: ${finalTotal}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid tip input. No tip added");
                                Console.WriteLine($"Final total: ${total}");
                            }
                            Console.WriteLine("THANK YOU FOR DINING WITH US\n\tENJOY YOUR MEAL\n");
                            Environment.Exit(0);
                        }
                        break;
                    default: 
                        {
                             Console.WriteLine("Please place the order from the menu only.\nLET'S PLACE THE ORDER CORRECTLY AGAIN\n");
                        } 
                        break;

                }

            }

        }
    }
}
