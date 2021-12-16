using DataEntity.Data;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.Repository
{
    public class UserRepository
    {
        public static bool SaveUser(tbl_users user)
        {
            using (var context = new TestingDBEntities())
            {
                if(user != null)
                {
                    context.tbl_users.Add(user);
                    return context.SaveChanges() >0;
                }
                return false;
            }
        }

        public static List<tbl_users> GetUsers()
        {
            using (var context = new TestingDBEntities())
            {
                var users = context.tbl_users.ToList();
                return users;
            }
        }
    }
}
