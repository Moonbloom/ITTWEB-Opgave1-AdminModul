using System;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class Component
    {
        public int Id { get; set; }
        public int ComponentNumber { get; set; }
        public String SerieNr { get; set; }
        public String AdminComment { get; set; }
        public String UserComment { get; set; }

        public virtual ComponentType ComponentType { get; set; }
        public virtual LoanInformation LoanInformation { get; set; }
    }
}