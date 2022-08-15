using System.ComponentModel.DataAnnotations;
namespace Note.Model
{
    public class Version
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int noteId { get; set; }

        public List<Noted> noteds { get; set; }
    }
}
