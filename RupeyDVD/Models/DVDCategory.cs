using System.ComponentModel.DataAnnotations;

namespace RupeyDVD.Models
{
    public class DVDCategory
    {
        [Key]
        public int CategoryNumber { get; set; }
        public string CategoryDescription { get; set; }
        public Boolean AgeRestricted { get; set; }
    }
}
