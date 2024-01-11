//==========================================================
// Student Number : S10258484
// Student Name : Yong Kai Yu
// Partner Name : Koh Yung Chun, Ivan
//==========================================================
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Assg01
{
    class Cone : IceCream
    {
        private bool dipped;
        public bool Dipped
        {
            get { return dipped; }
            set { dipped = value; }
        }
        public Cone() : base(){ }
        public Cone(string option, int scoops, List<Flavour> flavourList, List<Topping> toppingList, bool dipped) : base(option, scoops, flavourList, toppingList)
        {
            Dipped = dipped;
        }
        public override double CalculatePrice()
        {
            double cost = 0;
            int premium_flavour_count = 0;
            int topping_count = ToppingList.Count;
            double add_dipped = 0;
            foreach (Flavour flavour in FlavourList)
            {
                string flavour_str = Convert.ToString(flavour);
                flavour_str = flavour_str.ToUpper();
                if (flavour_str == "DURIAN" || flavour_str == "UBE" || flavour_str == "SEA SALT")
                {
                    premium_flavour_count += 1;
                }
            }
            if (Dipped = true)
            {
                add_dipped = 2;
            }
            if (Scoops == 1)
            {
                return 4 + add_dipped + (2 * premium_flavour_count) + (1 * topping_count);
            }
            else if (Scoops == 2)
            {
                return 5.5 + add_dipped + (2 * premium_flavour_count) + (1 * topping_count);
            }
            else if (Scoops == 3)
            {
                return 6.5 + add_dipped + (2 * premium_flavour_count) + (1 * topping_count);
            }
            return 0;
        }
        public override string ToString()
        {
            return base.ToString() + " Dipped: " + Dipped;
        }
    }

}
