using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Mobile number")]
        public string MobilNo { get; set; }
        [Display(Name = "Student id")]
        public string StudentId { get; set; }
        [Display(Name = "Student name")]
        public string StudentName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Loan id")]
        public int LoanInformationId { get; set; }
        public virtual IEnumerable<LoanInformation> LoanInformations { get; set; }
    }
}