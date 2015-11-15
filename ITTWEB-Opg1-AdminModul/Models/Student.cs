using System;
using System.Collections.Generic;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String MobilNo { get; set; }
        public String StudentId { get; set; }
        public String StudentName { get; set; }
        public String Email { get; set; }

        public int LoanInformationId { get; set; }
        public virtual IEnumerable<LoanInformation> LoanInformations { get; set; }
    }
}