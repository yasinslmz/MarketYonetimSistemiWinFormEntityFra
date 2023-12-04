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
    public class CategoryCrud : ICrud<Category>
    {
        DataContext db=new DataContext();
        public bool Add(Category entity)
        {
            if (entity != null)
            {
                db.Category.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return db.Category.Where(x => x.IsDelete == false).ToList();
        }

        public Category GetById(int id)
        {
            return db.Category.Find(id);
        }

        public bool Update(Category entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
