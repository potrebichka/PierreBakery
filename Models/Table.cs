using System;

namespace Bakery.Models {
    class Table {
        public static int tableWidth = 77;

        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public static void PrintRow(params string[] columns)
        {   
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public static void PrintRowWithId(params string[] columns)
        {   
            int width1 = 10;
            int width3 = 20;
            int width2 = (tableWidth - width3 -width1 -columns.Length-1);
            string row = "|";

            for (int i =0; i< columns.Length; i++)
            {
                string column = columns[i];
                if (i == 0) {
                   row += AlignCentre(column, width1) + "|"; 
                } else if (i == 1) {
                    row += AlignCentre(column, width2) + "|"; 
                } else {
                    row += AlignCentre(column, width3) + "|"; 
                }
                
            }

            Console.WriteLine(row);
        }

        public static void PrintRowWithIdCount(params string[] columns)
        {   
            int width1 = 5;
            int width3 = 10;
            int width4 = 10;
            int width2 = (tableWidth - width3 -width1 -width4 - columns.Length-1);
            string row = "|";

            for (int i =0; i< columns.Length; i++)
            {
                string column = columns[i];
                if (i == 0) {
                   row += AlignCentre(column, width1) + "|"; 
                } else if (i == 1) {
                    row += AlignCentre(column, width2) + "|"; 
                } else if (i == 3) {
                    row += AlignCentre(column, width3) + "|"; 
                } else  {
                    row += AlignCentre(column, width4) + "|"; 
                }
                
            }

            Console.WriteLine(row);
        }

        public static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        public static void PrintAlign (string text) {
            Console.WriteLine(AlignCentre(text, tableWidth));
        }
    }
}