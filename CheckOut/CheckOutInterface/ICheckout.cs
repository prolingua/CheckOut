using CheckOut.CheckOutClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.CheckOutInterface
{
    interface ICheckout
    {
        void Scan(string item, IList<ShoppingModel> shoppingList);
        int GetTotalPrice(IList<ShoppingModel> shoppingList);
    }
}
