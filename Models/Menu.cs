using System;
namespace Bakery.Models {
    class Menu {

        private BakeryItem[] Items;
        public Menu() {
            int index = 1;
            //breads
            Bread bread1 = new Bread("Traditional French Baguette", 3, index);
            Bread bread2 = new Bread("Small French Boule", 4.5, index++);
            Bread bread3 = new Bread("Kalamata Olive", 6, index++);
            Bread bread4 = new Bread("Walnut Raisin", 6, index++);
            Bread bread5 = new Bread("Brioche", 7.5, index++);
            Bread bread6 = new Bread("Whole Wheat Multi-Grain", 6.5, index++);
            Pastry pastry1 = new Pastry("Butter Croissant", 3, index);
            Pastry pastry2 = new Pastry("Chocolate Croissant", 3.5, index++);
            Pastry pastry3 = new Pastry("Almond Croissant", 3.5, index++);
            Pastry pastry4 = new Pastry("Chocolate Almond Croissant", 4, index++);
            Pastry pastry5 = new Pastry("Raspberry Almond Croissant", 4, index++);
            Pastry pastry6 = new Pastry("Pistachio White Chocolate Almond Croissant", 5, index++);
            Items = new BakeryItem[] {bread1, bread2, bread3, bread4, bread5, bread6, pastry1, pastry2, pastry3, pastry4, pastry5, pastry6};
        }

        public void PrintMenu() {
            Table.PrintAlign("------------------");
            Table.PrintAlign("MENU");
            Table.PrintAlign("------------------");
            Console.WriteLine();

            Table.PrintAlign("------------------");
            Table.PrintAlign("BREADS");
            Table.PrintAlign("------------------");
            Table.PrintLine();

            Table.PrintRowWithId(new string [] {"Id", "Name", "Price"});
            Table.PrintLine();

            for (int i = 0; i < 6; i++) {
                BakeryItem bread = Items[i];
                Table.PrintRowWithId(bread.Display());
                Table.PrintLine();
            }

            Table.PrintAlign("------------------");
            Table.PrintAlign("PASTRIES");
            Table.PrintAlign("------------------");
            Table.PrintLine();
    
            Table.PrintRowWithId(new string [] {"Id", "Name", "Price"});
            Table.PrintLine();

            for (int i = 6; i < 12; i++) {
                BakeryItem pastry = Items[i];
                Table.PrintRowWithId(pastry.Display());
                Table.PrintLine();
            }

            Table.PrintAlign("------------------");
            Table.PrintAlign("OFFERS");
            Table.PrintAlign("------------------");
            Table.PrintLine();

            Table.PrintRow(new string [] {"Product", "Offer"});
            Table.PrintLine();
            Table.PrintRow(new string [] {"Bread", "Buy any 2, get 1 free"});
            Table.PrintLine();
            Table.PrintRow(new string [] {"Pastry", "Buy any 3 for $8"});
            Table.PrintLine();
        }

        public BakeryItem FindItem(int id) {
            for (int i = 0; i < Items.Length; i++) {
                if (Items[i].Id == id) {
                    return Items[i];
                }
            }
            return new BakeryItem("", 0, 0);
        }

    }
}