using System.ComponentModel.DataAnnotations;
namespace Note.Model
{
    public class Version
    {
        public int Id { get; set; }
        [Required]

        public int VersionCode { get; set; }
        [Required]
        public DateTime? CreatedOn { get; set; }
        public Magazine Magazine { get; set; }
        public int MagazineId { get; set; }
      
    }
    }

