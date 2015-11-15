using System.Collections.Generic;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class ComponentType
    {
        public int Id { get; set; }
        public string ComponentName { get; set; }
        public string ComponentInfo { get; set; }
        public string Datasheet { get; set; }
        public string LocalImageUrl { get; set; }
        public string ManufacturerLink { get; set; }
        
        public virtual IEnumerable<Component> Component { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
