using System;

//===========================================================
// Student Number : S10262491
// Student Name : Koh Yung Chun Ivan
// Partner Name : Yong Kai Yu
//===========================================================

namespace Assg01
{
	class PointCard
	{
		private int points;
		private int punchCard;
		private string tier;

		public int Points { get; set; }
		public int PunchCard { get; set; }
		public string Tier { get; set; }

		public PointCard() { }

		public PointCard(int p, int pc)
		{
			Points = p;
			PunchCard = pc;
		}

		public void AddPoints(int points)
		{
			double addPoints = Math.Floor(points * 0.72);
			int newpoints = Convert.ToInt32(addPoints);
			Points += newpoints;

            //if (Points >= 100 && Tier != "Gold")
            //{
            //    Tier = "Gold";
            //}
            //else if (Points >= 50 && Tier == "Ordinary")
            //{
            //    Tier = "Silver";
            //}
            //else
            //{
            //    Tier = "Ordinary";
            //}
        }

		public void RedeemPoints(int redeemPoints)
		{
			if (Tier != "Ordinary")
			{
				if (Points >= redeemPoints)
				{
					Points -= redeemPoints;
					double dollarValue = redeemPoints * 0.02;
                    Console.WriteLine($"{redeemPoints} points redeemed, equating to ${dollarValue} off your bill.");
                }

				else
				{
					Console.WriteLine("Not enough points to redeem");
				}
                
			}

			else
			{
                Console.WriteLine("Only Silver and Gold members can redeem points.");
            }

			
		}

		public void Punch()
		{
			PunchCard++;
		}

		

        public override string ToString()
        {
            return $"Points: {Points} \nPunchCard: {PunchCard} \nTier: {Tier}";
        }
    }
}

