using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetProjectBror
{
    class ShoppingManager
    {
        List<Shopping> shoppings = null;
        public decimal budget { get; set; }
        public ShoppingManager(decimal budget)
        {
            this.budget = budget;
            shoppings = new List<Shopping>()
            {
                new Shopping{Date = "08 Oktober" , Place = "Ullared" , Cost =364},
                new Shopping{Date = "25 Oktober" , Place = "Postnord" , Cost =110},
                new Shopping{Date = "26 Oktober" , Place = "Ullared" , Cost = 180},
                new Shopping{Date = "27 Oktober" , Place = "Surface Tablet" , Cost = 2000},
                new Shopping{Date = "28 Oktober" , Place = "Gallerian" , Cost = 120},
                new Shopping{Date = "31 Oktober" , Place = "Hallon" , Cost = 100},
                new Shopping{Date = "6 November" , Place = "Hallon" , Cost = 74},
                new Shopping{Date = "10 November" , Place = "ÖoB" , Cost = 40},
                new Shopping{Date = "14 November" , Place = "ICA Kvatum" , Cost = 160},
                new Shopping{Date = "20 November" , Place = "Systembolaget" , Cost = 753},
                new Shopping{Date = "2 December" , Place = "Bridge" , Cost = 372},
                new Shopping{Date = "3 December" , Place = "Hallon" , Cost = 74},
                new Shopping{Date = "3 December" , Place = "THY Ticket" , Cost = 3700},
                new Shopping{Date = "4 December" , Place = "Hajen" , Cost = 353},
                new Shopping{Date = "9 December" , Place = "Dollar Store" , Cost = 310},
                new Shopping{Date = "11 December" , Place = "Hajen" , Cost = 434},
                new Shopping{Date = "30 December" , Place = "Documents" , Cost = 850},
                new Shopping{Date = "2 Januari" , Place = "Hallon" , Cost = 149},
                new Shopping{Date = "14 Januari" , Place = "Hajen" , Cost = 320},
                new Shopping{Date = "21 Januari" , Place = "Padel" , Cost = 100},
                new Shopping{Date = "27 Januari" , Place = "Ullared" , Cost = 945},
                new Shopping{Date = "29 Januari" , Place = "Padel" , Cost = 160},
                new Shopping{Date = "30 Januari" , Place = "Hajen" , Cost = 175},
                new Shopping{Date = "3 Februari" , Place = "Jysk" , Cost = 100},
                new Shopping{Date = "4 Februari" , Place = "Pad" , Cost = 240},
                new Shopping{Date = "4 Februari" , Place = "Hallon" , Cost = 149},
                new Shopping{Date = "7 Februari" , Place = "Ullared swish Samir" , Cost = 400},
                new Shopping{Date = "3 March" , Place = "Hallon" , Cost = 149},
                new Shopping{Date = "4 March" , Place = "Padel mustafa swish", Cost = 70},
                new Shopping{Date = "5 March" , Place = "Samir swish", Cost = 450},
                new Shopping{Date = "7 March", Place = "ICA Hajen", Cost = 120},
                new Shopping{Date = "30 March", Place = "Ica Hajen", Cost = 128},
                new Shopping{Date = "4 April", Place = "ICA Hajen", Cost = 60},
                new Shopping{Date = "5 Aprıl", Place = "Samir swish", Cost = 1900}
            };
        }

        public List<Shopping> GetShoppings()
        {
            return shoppings;
        }

        public decimal CalculateTotalCost()
        {
            decimal paidCost = 0;

            foreach (var shopping in shoppings)
            {
                paidCost = shopping.Cost + paidCost;
            }
            return paidCost;
        }

        public decimal CalculateRemainingMoney()
        {
            decimal paidCost = CalculateTotalCost();

            return budget - paidCost;
        }
    }
}
