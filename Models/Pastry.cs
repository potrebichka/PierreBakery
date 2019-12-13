using System;

namespace Bakery.Models {
    class Pastry : BakeryItem {
        public Pastry(string name, double cost, int id): base (name, cost, id) {
            Name = name;
            Cost = Math.Round(cost, 2);
            Id = id;
        }
    }
}