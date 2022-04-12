using System.ComponentModel.DataAnnotations;

namespace RupeyDVD.Models
{
    public class Actor
    {
        public Actor()
        {
            this.DVDTitles = new HashSet<DVDTitle>();
        }
        [Key]
        public int ActorNumber { get; set; }
        public string ActorSurName { get; set; }
        public string ActorFirstName { get; set; }

        public virtual ICollection<DVDTitle> DVDTitles { get; set; }
    }
}
