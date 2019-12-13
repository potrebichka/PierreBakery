using System;

namespace Bakery {
    class Bakery {
        public static void Main() {
            Console.WriteLine("Welcome to Pierre's Bakery\n");
            Console.WriteLine("Enter you name:");
            string userName = Console.ReadLine();
            DateTime myDate = DateTime.Now;
            Console.WriteLine(myDate);
        }
    }
}