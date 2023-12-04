using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity
{
    // SellProduct - Id,OrderId,ProductId,Quantity,Price,TotalPrice,İsDelete
    public class SellProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order{ get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public bool IsDelete { get; set; }
    }
}
