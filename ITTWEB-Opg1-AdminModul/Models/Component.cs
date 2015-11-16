using System.ComponentModel.DataAnnotations;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class Component
    {
        public int Id { get; set; }
        [Display(Name = "Component number")]
        public int ComponentNumber { get; set; }
        [Display(Name = "Serie number")]
        public string SerieNr { get; set; }
        [Display(Name = "Admin comment")]
        public string AdminComment { get; set; }
        [Display(Name = "User comment")]
        public string UserComment { get; set; }

        [Display(Name = "Component type id")]
        public int ComponentTypeId { get; set; }
        public virtual ComponentType ComponentType { get; set; }
        [Display(Name = "Loan id")]
        public int? LoanInformationId { get; set; }
        public virtual LoanInformation LoanInformation { get; set; }
    }
}