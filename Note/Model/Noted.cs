using System.ComponentModel.DataAnnotations;
namespace Note.Model
{
    public class Noted
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastupdatedOn { get; set; }

        public User user { get; set; }
        public int userId { get; set; }

        public Version version { get; set; }

        public int VersionId { get; set; } 
    }
}
