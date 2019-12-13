using System;

namespace Bakery.Models {
    class Pastry {
        public string Name {get;set;}
        public double Cost {get;set;}
        public int Id {get; set;}
        public Pastry(string name, double cost, int id) {
            Name = name;
            Cost = Math.Round(cost, 2);
            Id = id;
        }
        public string [] Display() {
            return new string[] {Id.ToString(), Name, "$" + Cost.ToString()};
        }
    }
}