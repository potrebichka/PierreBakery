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
                Table.PrintAlign($"Good morning, {userName}!");
            } else if (myDateHour >= 12 && myDateHour < 17) {
                Table.PrintAlign($"Good afternoon, {userName}!");
            } else if (myDateHour >= 1 && myDateHour < 5) {
                Table.PrintAlign($"Hello {userName}!");
            } else {
                Table.PrintAlign($"Good evening, {userName}");
            }

            //breads
            Menu menu = new Menu();
            menu.PrintMenu();

        }
    }
}