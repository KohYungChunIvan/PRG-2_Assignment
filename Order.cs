using System;
using System.Diagnostics;

//===========================================================
// Student Number : S10262491
// Student Name : Koh Yung Chun Ivan
// Partner Name : Yong Kai Yu
//===========================================================

namespace Assg01
{
	class Order
	{
		private int id;
		private DateTime timeReceived;
		private DateTime? timeFulfilled;
		private List<IceCream> iceCreamList;

		public int Id { get; set; }
		public DateTime TimeReceived { get; set; }
		public DateTime? TimeFulfilled { get; set; }
		public List<IceCream> IceCreamList { get; set; } = new List<IceCream>();


        public Order()
		{

        }

		public Order(int i, DateTime tr)
		{
			Id = i;
			TimeReceived = tr;
        }
        
        public void ModifyIceCream(int index)
        {
            if (index >= 0 && index < IceCreamList.Count)
            {
                IceCream iceCreamToModify = IceCreamList[index];
            }
            else
            {
                Console.WriteLine("The index provided is out of range.");
            }
        }

        public void AddIceCream(IceCream iceCream)
        {
            IceCreamList.Add(iceCream);
        }

        public void DeleteIceCream(int index)
        {
            if (index >= 0 && index < IceCreamList.Count)
            {
                IceCreamList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("The index provided is out of range.");
            }
        }

        public double CalculateTotal()
        {
            double total = 0.0;
            
            foreach (IceCream iceCream in IceCreamList)
            {
                total += iceCream.CalculatePrice(); //For the icecream price
            }
            return total;
        }




        //public double ApplyingBirthdayDiscount(Customer customer)
        //{
        //    double total = CalculateTotal();
        //    double highestPrice = 0.0;
        //    IceCream mostExpensiveIceCream = null;


        //    if (customer.IsBirthday())
        //    {
        //        foreach (var iceCream in IceCreamList)
        //        {
        //            double price = iceCream.CalculatePrice();
        //            if (price > highestPrice)
        //            {
        //                highestPrice = price;
        //                mostExpensiveIceCream = iceCream;
        //            }
        //        }

        //        // Deduct the price of the most expensive ice cream if it's the customer's birthday
        //        total -= highestPrice;

        //    }
        //    return total;

        //}

        public override string ToString()
        {
            return $"Order ID: {Id} \nTime Received: {TimeReceived} \nTime Fulfilled: {TimeFulfilled}";
        }
    }
}

