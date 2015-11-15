namespace ITTWEB_Opg1_AdminModul.Models
{
    public class Component
    {
        public int Id { get; set; }
        public int ComponentNumber { get; set; }
        public string SerieNr { get; set; }
        public string AdminComment { get; set; }
        public string UserComment { get; set; }

        public int ComponentTypeId { get; set; }
        public virtual ComponentType ComponentType { get; set; }
        public int? LoanInformationId { get; set; }
        public virtual LoanInformation LoanInformation { get; set; }
    }
}