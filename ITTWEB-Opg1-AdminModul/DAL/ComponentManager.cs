using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.DAL
{
    class ComponentManager
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
    }
}