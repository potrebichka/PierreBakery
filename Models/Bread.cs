namespace Bakery.Models {
    class Bread {
        public string Name {get;set;}
        public int Cost {get;set;}
        public Bread(string name, int cost) {
            Name = name;
            Cost = cost;
        }
    }
}