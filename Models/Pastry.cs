namespace Bakery.Models {
    class Pastry {
        public string Name {get;set;}
        public int Cost {get;set;}
        public void Pastry(string name, int cost) {
            Name = name;
            Cost = cost;
        }
    }
}