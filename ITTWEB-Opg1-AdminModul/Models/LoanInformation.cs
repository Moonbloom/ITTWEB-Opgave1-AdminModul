using System;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class LoanInformation
    {
        public int Id { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsEmailSend { get; set; }
        public bool IsReservation { get; set; }
        public DateTime? ReservationDate { get; set; }
        
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}