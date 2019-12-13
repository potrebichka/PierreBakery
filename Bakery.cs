using System;

namespace Bakery {
    class Bakery {
        public static void Main() {
            Console.WriteLine("Welcome to Pierre's Bakery\n");

            Console.WriteLine("Enter you name:");
            string userName = Console.ReadLine();

            int myDateHour = DateTime.Now.Hour;
            if (myDateHour >= 5 && myDateHour < 12) {
                Console.WriteLine($"Good morning, {userName}!");
            } else if (myDateHour >= 12 && myDateHour < 17) {
                Console.WriteLine($"Good afternoon, {userName}!");
            } else if (myDateHour >= 1 && myDateHour < 5) {
                Console.WriteLine($"Hello {userName}!");
            } else {
                Console.WriteLine($"Good evening, {userName}");
            }

            Console.WriteLine("------------------");
            Console.WriteLine("MENU");
            Console.WriteLine("------------------");
        }
    }
}