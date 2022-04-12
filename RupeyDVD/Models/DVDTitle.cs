using System.ComponentModel.DataAnnotations;

namespace RupeyDVD.Models
{
    public class DVDTitle
    {
        public DVDTitle()
        {
            this.Actors = new HashSet<Actor>();
        }
        [Key]
        public int DVDNumber { get; set; }
        public string DVDTitles { get; set; }
        public DateTime DateReleased { get; set; }
        public float StandardCharge { get; set; }
        public float PenaltyCharge { get; set; }
        public DVDCategory DVDCategory { get; set; }
        public Studio Studio { get; set; }
        public Producer Producer { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }
    }
}
