﻿using CheckOut.CheckOutInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.CheckOutClass
{
    public class Checkout : ICheckout
    {
        PriceRuleTable priceRuleTable = new PriceRuleTable();
        public void Scan(string item, IList<ShoppingModel> shoppingList)
        {
           
        }

        public int GetTotalPrice(IList<ShoppingModel> shoppingList)
        {
            int totalPrice = 0;

            return totalPrice; 
        }
    }
}
