using System.Collections.Generic;
using System.Linq;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.DAL
{
    public class AppDbManager
    {
        public IList<ApplicationUser> GetAllApplicationUsers()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Users.ToList();
            }
        }

        public ApplicationUser GetApplicationUser(string id)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Users.Find(id);
            }
        }

        public ApplicationUser GetApplicationUserByName(string userName)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Users.FirstOrDefault(u => u.UserName == userName);
            }
        }

        public void DeleteApplicationUser(string id)
        {
            using (var db = new ApplicationDbContext())
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public string GetRealRoleName(string id)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Roles.FirstOrDefault(role => role.Id == id).Name;
            }
        }
    }
}