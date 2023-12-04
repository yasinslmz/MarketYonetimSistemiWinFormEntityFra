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
    public class UserCrud : ICrud<User>
    {
        DataContext db=new DataContext();

        public bool Add(User entity)
        {
            if (entity != null)
            {
                db.User.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var user = db.User.FirstOrDefault(x => x.Id == id);


            if (user != null)
            {
                db.User.Remove(user);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<User> GetAll()
        {
            return db.User.Where(x => x.IsDelete == false && x.RoleId!=2).ToList();
        }

        public User GetById(int id)
        {
            return db.User.Find(id);
        }
        public User GetByIntros(User user)
        {
            User foundUser = db.User.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            if (foundUser!=null) {
                return foundUser;

            }
            else
            {
                return null;
            }
        }
        public bool Update(User entity, int id)
        {
            var user = db.User.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(entity.Name))
                {
                    user.Name = entity.Name;
                }
                if (!string.IsNullOrEmpty(entity.Surname))
                {
                    user.Surname = entity.Surname;
                }
                if (!string.IsNullOrEmpty(entity.Email))
                {
                    user.Email = entity.Email;
                }
                if (!string.IsNullOrEmpty(entity.Password))
                {
                    user.Password = entity.Password;
                }
                
                user.IsStatus = entity.IsStatus;
                

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
