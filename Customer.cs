using System;

//===========================================================
// Student Number : S10262491
// Student Name : Koh Yung Chun Ivan
// Partner Name : Yong Kai Yu
//===========================================================

namespace Assg01
{
	class Customer
	{
		private string name;
		private int memberId;
		private DateTime dob;
		private Order currentOrder;
		private List<Order> orderHistory;
		private PointCard rewards;
		
		public string Name { get; set; }
		public int MemberId { get; set; }
		public DateTime Dob { get; set; }
		public Order CurrrentOrder { get; set; }
		public List<Order> OrderHistory { get; set; } = new List<Order>();
        public PointCard Rewards { get; set; }


		public Customer()
		{
			
		}

		public Customer(string n, int m, DateTime d)
		{
			Name = n;
			MemberId = m;
			Dob = d;
        }

		public Order MakeOrder()
		{
			Order currentOrder = new Order();
			OrderHistory.Add(currentOrder);
			return currentOrder;
		}

        public bool IsBirthday()
        {
            if (DateTime.Today.Month == Dob.Month && DateTime.Today.Day == Dob.Day)
			{
				return true;
			}

			else
			{
				return false;
			}
        }

        public override string ToString()
        {
			return $"Name: {Name} \nMemberId: {MemberId} \nDOB: {Dob.ToShortDateString()} \nPoints: {Rewards.Points}, \nTier: {Rewards.Tier}";
        }

    }
}

