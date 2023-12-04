using MarketYönetimSistemi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.Interface
{
    internal class ProductCrud : ICrud<Product>
    {

        DataContext db=new DataContext();
        public bool Add(Product entity)
        {
            if (entity != null)
            {
                db.Product.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var product = db.Product.FirstOrDefault(x => x.Id == id);
            

            if (product != null)
            {
                db.Product.Remove(product);
                db.SaveChanges();
                return true;
            }
            else
            {
                 return false;
            }
        }

        public List<Product> GetAll()
        {
            return db.Product.Where(x=>x.IsDelete==false).ToList();
        }

        public Product GetById(int id)
        {
            if (db.Product.Find(id).Stock > 0)
            {
                return db.Product.Find(id); 
            }
            else
            {
                return null;
            }
        }

        public bool Update(Product entity, int id)
        {
            var product=db.Product.FirstOrDefault(x => x.Id == id);
            if (product!=null)
            {
                if (!string.IsNullOrEmpty(entity.Name))
                {
                    product.Name = entity.Name;
                }
                if (!string.IsNullOrEmpty(entity.Description))
                {
                    product.Description = entity.Description;
                }
                if (entity.Price!=0) // Price null değilse
                {
                    product.Price = entity.Price;
                }
                if (entity.Stock != 0) // Price null değilse
                {
                    product.Stock -= entity.Stock;
                }
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
