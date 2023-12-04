using MarketYönetimSistemi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity
{
    public class Product : CommonProperty
    {
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BuyProduct> BuyProductList { get; set; }
        public List<SellProduct> SellProductList { get; set; }

    }
}
