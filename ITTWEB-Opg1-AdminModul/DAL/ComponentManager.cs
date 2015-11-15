using System.Collections.Generic;
using System.Linq;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.DAL
{
    public class ComponentManager
    {
        public Component CreateComponent(Component component)
        {
            using (var db = new EsDbContext())
            {
                db.Components.Add(component);
                db.SaveChanges();
                return component;
            }
        }

        public List<Component> GetAllComponents()
        {
            using (var db = new EsDbContext())
            {
                var result = db.Components.Include("ComponentType").ToList();
                return result;
            }
        } 
    }
}