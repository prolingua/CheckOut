using CheckOut.CheckOutInterface;
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
            if (!priceRuleTable.PriceRules.Any(p => p.SKU == item))
            {
                throw new SkuNotExistException(item + " not available");
            }

            if (shoppingList == null)
            {
                shoppingList = new List<ShoppingModel>();
            }

            ShoppingModel shoppingModel = shoppingList.SingleOrDefault(s => s.Sku == item);

            if (shoppingModel == null)
            {
                shoppingList.Add(new ShoppingModel { Sku = item, Quantity = 1 });
            }
            else
            {
                shoppingModel.Quantity += 1;
            }
        }

        public int GetTotalPrice(IList<ShoppingModel> shoppingList)
        {
            int totalPrice = 0;

            if (shoppingList == null || shoppingList.Count == 0)
            {
                return totalPrice;
            }

            foreach (var shoppingModel in shoppingList)
            {
                int unit = 1;
                int unitPrice = priceRuleTable.PriceRules.SingleOrDefault(p => p.SKU == shoppingModel.Sku && p.Unit == unit).Price;
                int totalQuantity = shoppingModel.Quantity;
                totalPrice += totalQuantity * unitPrice;
            }
            return totalPrice; 
        }
    }
}
