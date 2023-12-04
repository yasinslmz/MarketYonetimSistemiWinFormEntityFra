using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Controller
{
    public class OrderCrud : ICrud<Order>
    {
        DataContext db=new DataContext();
        public bool Add(Order entity)
        {
            if (entity != null)
            {
                db.Order.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            return db.Order.Where(x => x.İsDelete == false).ToList();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
