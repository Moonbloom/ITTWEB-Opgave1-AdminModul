using System;
using System.ComponentModel.DataAnnotations;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class LoanInformation
    {
        public int Id { get; set; }
        [Display(Name = "Loan date")]
        public DateTime? LoanDate { get; set; }
        [Display(Name = "Return date")]
        public DateTime ReturnDate { get; set; }
        [Display(Name = "Email send")]
        public bool IsEmailSend { get; set; }
        [Display(Name = "Reservation")]
        public bool IsReservation { get; set; }
        [Display(Name = "Reservation date")]
        public DateTime? ReservationDate { get; set; }

        [Display(Name = "Student id")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}