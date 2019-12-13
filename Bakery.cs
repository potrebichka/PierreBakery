using System;
using Bakery.Models;

namespace Bakery {
    class Bakery {
        public static void Main() {
            Table.PrintAlign("Welcome to Pierre's Bakery");
            Table.PrintAlign("------------------\n");

            Console.WriteLine("Enter you name:");
            string userName = Console.ReadLine();

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

            Menu menu = new Menu();
            menu.PrintMenu();

            bool condition = true;
            while (condition) {
                Console.WriteLine("Choose option:");
                Console.WriteLine("[1]: MENU");
                Console.WriteLine("[2]: CART");
                Console.WriteLine("[3]: Add item to CART");
                Console.WriteLine("[4]: Remove item from CART");
                Console.WriteLine("[5]: Exit program");

                string userInput = Console.ReadLine();
                switch (userInput) {
                    case "1":
                        menu.PrintMenu();
                        break;
                    case "5":
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