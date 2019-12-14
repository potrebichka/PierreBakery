using System;
using Bakery.Models;
using System.Drawing;

namespace Bakery {
    class Bakery {
        public static void Main() {
            Table.PrintAlign("Welcome to Pierre's Bakery");
            Table.PrintAlign("------------------\n");

            Console.WriteLine("------------------");
            Console.WriteLine("Enter you name:");
            string userName = Console.ReadLine();
            Console.WriteLine("------------------");

            int myDateHour = DateTime.Now.Hour;
            if (myDateHour >= 5 && myDateHour < 12) {
                Table.PrintAlign(userName == "" ? $"Good morning!" : $"Good morning, {userName}!");
            } else if (myDateHour >= 12 && myDateHour < 17) {
                Table.PrintAlign(userName == "" ? $"Good morning!" : $"Good afternoon, {userName}!");
            } else if (myDateHour >= 1 && myDateHour < 5) {
                Table.PrintAlign(userName == "" ? $"Good morning!" : $"Hello {userName}!");
            } else {
                Table.PrintAlign(userName == "" ? $"Good morning!" : $"Good evening, {userName}");
            }
            Console.WriteLine();

            Menu menu = new Menu();
            menu.PrintMenu();
            Cart cart = new Cart();

            bool condition = true;
            while (condition) {
                Console.WriteLine("------------------");
                Console.WriteLine("Choose option:");
                Console.WriteLine("[1]: MENU");
                Console.WriteLine("[2]: CART");
                Console.WriteLine("[3]: Add item to CART");
                Console.WriteLine("[4]: Remove item from CART");
                Console.WriteLine("[5]: BUY");
                Console.WriteLine("[6]: Empty Cart");
                Console.WriteLine("[7]: Exit program");
                Console.WriteLine("------------------");

                string userInput = Console.ReadLine();
                Console.WriteLine("------------------");
                switch (userInput) {
                    case "1":
                        menu.PrintMenu();
                        break;
                    case "2":
                        cart.DisplayCart();
                        break;
                    case "3":
                        Console.WriteLine("Enter id of item to add");
                        string addIdInput = Console.ReadLine();
                        if (addIdInput != "") 
                        {
                            Console.WriteLine("Enter how many items do you want to add:");
                            string quantityAnswer = Console.ReadLine();
                            for (int i =0; i < int.Parse(quantityAnswer); i++) {
                                cart.AddItem(int.Parse(addIdInput));
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter id of item to remove");
                        string removeIdInput = Console.ReadLine();
                        if (removeIdInput != "") 
                        {
                            cart.RemoveItem(int.Parse(removeIdInput));
                        }
                        break;
                    case "5":
                        if (cart.isEmpty()) {
                            Table.PrintAlign("You cart is empty.");
                        } else {
                            Table.PrintAlign("Thank you for shopping in Pierre's bakery!");
                            cart.DisplayOrder();
                        }

                        cart = new Cart();
                        break;
                    case "6":
                        Console.WriteLine("You cart is empty");
                        cart = new Cart();
                        break;
                    case "7":
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }

            Table.PrintAlign(userName == "" ? $"Good Bye!" : $"Good bye, {userName}!");
        }
    }
}