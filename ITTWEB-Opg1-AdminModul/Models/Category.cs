using System.ComponentModel.DataAnnotations;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string CategoryName { get; set; }
    }
}