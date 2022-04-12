using System.ComponentModel.DataAnnotations;

namespace RupeyDVD.Models
{
    public class Loan
    {
        [Key]
        public int LoanNumber { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateReturned { get; set; }
        public LoanType LoanType { get; set; }
        public DVDCopy DVDCopy { get; set; }
        public Member Member { get; set; }
    }
}
