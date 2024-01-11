//==========================================================
// Student Number : S10258484
// Student Name : Yong Kai Yu
// Partner Name : Koh Yung Chun, Ivan
//==========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg01
{
    class Cup : IceCream
    {
        public Cup() : base() { }

        public Cup(string option, int scoops, List<Flavour> flavourList, List<Topping> toppingList) : base(option, scoops, flavourList, toppingList) { }


        public override double CalculatePrice()
        {
            double cost = 0;
            int topping_count = ToppingList.Count;
            int premium_flavour_count = 0;
            foreach(Flavour flavour in FlavourList)
            {
                string flavour_str = Convert.ToString(flavour);
                flavour_str = flavour_str.ToUpper();
                if (flavour_str == "DURIAN" || flavour_str == "UBE" || flavour_str == "SEA SALT")
                {
                    premium_flavour_count += 1;
                }
            }
            if (Scoops == 1)
            {
                return 4 + (2 * premium_flavour_count) + (1 * topping_count);
            }
            else if (Scoops == 2)
            {
                return 5.5 + (2 * premium_flavour_count) + (1 * topping_count);
            }
            else if (Scoops == 3)
            {
                return 6.5 + (2 * premium_flavour_count) + (1 * topping_count);
            }
            return 0;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
