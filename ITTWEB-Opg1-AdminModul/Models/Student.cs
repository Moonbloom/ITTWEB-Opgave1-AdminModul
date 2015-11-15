using System.Collections.Generic;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string MobilNo { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public int LoanInformationId { get; set; }
        public virtual IEnumerable<LoanInformation> LoanInformations { get; set; }
    }
}