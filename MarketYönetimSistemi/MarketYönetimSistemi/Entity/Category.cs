using MarketYönetimSistemi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity
{
    public class Category : CommonProperty
    {
        public List<Product> ProductList { get; set; }
    }
}
