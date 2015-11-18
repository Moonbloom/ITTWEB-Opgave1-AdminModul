using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class ComponentType
    {
        public int Id { get; set; }
        [Display(Name = "Component name")]
        public string ComponentName { get; set; }
        [Display(Name = "Component info")]
        public string ComponentInfo { get; set; }
        [Display(Name = "Datasheet")]
        public string Datasheet { get; set; }
        [Display(Name = "Image")]
        public string LocalImageUrl { get; set; }
        [Display(Name = "Manufacturer")]
        public string ManufacturerLink { get; set; }
        
        public virtual IEnumerable<Component> Component { get; set; }
        [Display(Name = "Category id")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
