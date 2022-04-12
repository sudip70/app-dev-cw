using System.ComponentModel.DataAnnotations;

namespace RupeyDVD.Models
{
    public class DVDCopy
    {
        [Key]
        public int CopyNumber { get; set; }
        public DateTime DatePurchased { get; set; }
        public DVDTitle DVDTitle { get; set; }
    }
}
