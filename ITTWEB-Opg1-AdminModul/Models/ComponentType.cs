using System;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class ComponentType
    {
        public int Id { get; set; }
        public String ComponentName { get; set; }
        public String ComponentInfo { get; set; }
        public String Datasheet { get; set; }
        public String LocalImageUrl { get; set; }
        public String ManufacturerLink { get; set; }

        public int ComponentId { get; set; }
        public virtual Component Component { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
