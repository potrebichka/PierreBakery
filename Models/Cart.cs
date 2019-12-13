using System;
using System.Collections.Generic;
namespace Bakery.Models {
    class Cart {
        private List<BakeryItem> Items;
        private Menu menu = new Menu();
        private Dictionary <BakeryItem, int> CountDict = new Dictionary<BakeryItem, int>(); 

        public Cart() {
            Items = new List<BakeryItem>{};
        }

        public void AddItem(int id) {
            BakeryItem item = menu.FindItem(id);
            if (item.Id == 0) {
                Console.WriteLine("Item was not found!");
            } else {
                Items.Add(item);
                Console.WriteLine($"Item was added to the CART: / Id: {item.Id} , Name: {item.Name}, Cost: {item.Cost} /");
                if (CountDict.ContainsKey(item)) {
                    CountDict[item] += 1;
                } else {
                    CountDict.Add(item, 1);
                }
            }

        }

        public void RemoveItem(int id) {
            BakeryItem item = new BakeryItem("", 0, 0);
            for (int i = Items.Count - 1; i>= 0; i--) {
                if (Items[i].Id == id) {
                    item = Items[i];
                    Items.RemoveAt(i);
                    break;
                }
            }
            if (item.Id == 0) {
                Console.WriteLine("Item was not found!");
            } else {
                Console.WriteLine($"Item was deleted from the CART: / Id: {item.Id} , Name: {item.Name}, Cost: {item.Cost} /");

                if (CountDict.ContainsKey(item)) {
                    CountDict[item] -= 1;
                    if (CountDict[item] <= 0) {
                        CountDict.Remove(item);
                    }
                }
            }

        }

        private double CalculatePrice() {
            double price = 0;
            int countOffer1 = 0;
            int countOffer2 = 0;
            double sumOffer2 = 0;
            for (int i = 0; i < Items.Count; i++) 
            {
                if (Items[i].GetType() == typeof(Bread)) 
                {
                    if (countOffer1 == 0) 
                    {
                        price += Items[i].Cost;
                        countOffer1 = 1;
                    } 
                    else 
                    {
                        countOffer1 = 0;
                    }
                }
                else 
                {
                    if (countOffer2 == 2) 
                    {
                        price = price - sumOffer2 + 8;
                        countOffer2 = 0;
                        sumOffer2 = 0;
                    }
                    else 
                    {
                        price += Items[i].Cost;
                        sumOffer2 += Items[i].Cost;
                        countOffer2 += 1;
                    }
                }
            }
            return price;
        }

        public void DisplayCart() {
            Table.PrintAlign("------------------");
            Table.PrintAlign("CART");
            Table.PrintAlign("------------------");
            Table.PrintLine();

            if (Items.Count == 0) 
            {
                Table.PrintAlign("Empty Cart");
                Table.PrintAlign("------------------");
            } 
            else
            {
                Table.PrintRowWithIdCount(new string [] {"Id", "Product", "Cost", "Count"});
                Table.PrintLine();

                foreach( KeyValuePair<BakeryItem, int> kvp in CountDict )
                {
                    BakeryItem item = kvp.Key;
                    string [] result = item.Display();
                    string [] count =  new string[] {kvp.Value.ToString()};
                    string [] combined = new string[result.Length + count.Length];
                    Array.Copy(result, combined, result.Length);
                    Array.Copy(count, 0, combined, result.Length, count.Length);
                    Table.PrintRowWithIdCount(combined);
                    Table.PrintLine();
                }
            }
            Table.PrintAlign($"Total Cost: ${String.Format("{0:0.00}", CalculatePrice())}"); 
            Table.PrintLine();
        }

    }
}