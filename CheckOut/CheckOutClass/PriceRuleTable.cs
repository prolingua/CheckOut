using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.CheckOutClass
{
    public class PriceRuleModel
    {
        public string SKU { get; set; }
        public int Unit { get; set; }
        public int Price { get; set; }

    }

    public class PriceRuleTable
    {
        IList<PriceRuleModel> priceRules = new List<PriceRuleModel>();
        public PriceRuleTable()
        {
            priceRules.Add(new PriceRuleModel { SKU = "A", Unit = 1, Price = 50 });
            priceRules.Add(new PriceRuleModel { SKU = "B", Unit = 1, Price = 30 });
            priceRules.Add(new PriceRuleModel { SKU = "C", Unit = 1, Price = 20 });
            priceRules.Add(new PriceRuleModel { SKU = "D", Unit = 1, Price = 15 });
            priceRules.Add(new PriceRuleModel { SKU = "A", Unit = 3, Price = 130 });
            priceRules.Add(new PriceRuleModel { SKU = "B", Unit = 2, Price = 45 });

        }

        public IList<PriceRuleModel> PriceRules { get { return priceRules; } }
    }
}
