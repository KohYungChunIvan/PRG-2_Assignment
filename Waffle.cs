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
using System.Xml.Schema;

namespace Assg01
{
    class Waffle : IceCream
    {
        private string waffleFlavour;

        public string WaffleFlavour
        {
            get { return waffleFlavour; }
            set { waffleFlavour = value;}
        }
        public Waffle() : base() { }

        public Waffle(string option, int scoops, List<Flavour> flavourList, List<Topping> toppingList, string waffleFlavour) : base(option, scoops, flavourList, toppingList)
        {
            WaffleFlavour = waffleFlavour;
        }
        public override double CalculatePrice()
        {
            double cost = 0;
            int premium_flavour_count = 0;
            int topping_count = ToppingList.Count;
            double add_premium_waffle = 0;

            foreach (Flavour flavour in FlavourList)
            {
                string flavour_str = Convert.ToString(flavour);
                flavour_str = flavour_str.ToUpper();
                if (flavour_str == "DURIAN" || flavour_str == "UBE" || flavour_str == "SEA SALT")
                {
                    premium_flavour_count += 1;
                }
            }
            WaffleFlavour = WaffleFlavour.ToUpper();
            if (WaffleFlavour == "RED VELVET" || WaffleFlavour == "CHARCOAL" || WaffleFlavour == "PANDAN")
            {
                add_premium_waffle = 3;
            }

            if (Scoops == 1)
            {
                return 7 + + add_premium_waffle + (2 * premium_flavour_count) + (1 * topping_count);
            }
            else if (Scoops == 2)
            {
                return 8.5 + add_premium_waffle + (2 * premium_flavour_count) + (1 * topping_count);
            }
            else if (Scoops == 3)
            {
                return 9.5 + add_premium_waffle + (2 * premium_flavour_count) + (1 * topping_count);
            }
            return 0;
        }
        public override string ToString()
        {
            return base.ToString() + " Waffle Flavour: " + WaffleFlavour;
        }
    }
}
