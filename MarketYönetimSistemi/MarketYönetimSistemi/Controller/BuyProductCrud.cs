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
    public class BuyProductCrud : ICrud<BuyProduct>
    {
        DataContext db=new DataContext();
        public bool Add(BuyProduct entity)
        {
            if (entity != null)
            {
                db.BuyProduct.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BuyProduct> GetAll()
        {
            return db.BuyProduct.Where(x=>x.İsDelete==false).ToList();
        }

        public BuyProduct GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(BuyProduct entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
