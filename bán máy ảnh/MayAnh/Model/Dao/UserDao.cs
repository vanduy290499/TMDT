using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;
namespace Model.Dao
{
    public class UserDao
    {
        Model1 db = null;
        public UserDao()
        {
            db = new Model1();
        }
        public int Insert(user entity)
        {
            db.user.Add(entity);
            db.SaveChanges();
            return entity.id;
        }
       
        public int Login(String userName, string passWord)
        {
\            var resurt = db.user.SingleOrDefault(x => x.UserName == userName && x.PassWord==passWord);
            if (resurt == null)
            {
                return 0;
            }
            //else
            //{
            //    return 1;
            //}

            else if (resurt.PassWord == passWord)
                return 1;
            else
                return 2;


        }

        public user GetByid(string userName)
        {
            return db.user.SingleOrDefault(x => x.UserName == userName);
        }
        //public admin Getbyid(string userName)
        //{
        //    return db.admin.SingleOrDefault(x => x.username == userName);
        //}

        public IEnumerable <user> Listuser(int page, int pagesize)
        {
            var list = db.user.OrderByDescending(x => x.id).ThenByDescending(x=>x.UserName).ToPagedList(page, pagesize);
            return list;
        }
        public bool Deleted(int id)
        {
            var xoa = db.user.Find(id);
            db.user.Remove(xoa);
            db.SaveChanges();
            return true;
        }


    }
}
