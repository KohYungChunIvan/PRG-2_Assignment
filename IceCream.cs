//==========================================================
// Student Number : S10258484
// Student Name : Yong Kai Yu
// Partner Name : Koh Yung Chun, Ivan
//==========================================================
namespace Assg01
{
    abstract class IceCream
    {
        private string option;
        public string Option
        {
            get { return option; }
            set { option = value; }
        }
        private int scoops;
        public int Scoops
        {
            get { return scoops; }
            set { scoops = value; }
        }
        public List<Flavour> FlavourList { get; set; } = new List<Flavour>();
        public List<Topping> ToppingList { get; set; } = new List<Topping>();
        public IceCream() { }

        public IceCream(string option, int scoops, List<Flavour> flavourList, List<Topping> toppingList)
        {
            Option = option;
            Scoops = scoops;
            FlavourList = flavourList;
            ToppingList = toppingList;
        }
        abstract public double CalculatePrice();
        public override string ToString()
        {
            string flavour_string = "";
            foreach (Flavour flavour in FlavourList)
            {
                flavour_string += flavour + ",";
            }
            string topping_string = "";
            foreach (Topping topping in ToppingList)
            {
                topping_string += topping + ",";
            }
            return "Option: " + Option + " Scoop(s):" + Scoops + " Flavours: " + flavour_string + " Topping: " + topping_string;
        }
    }
}
