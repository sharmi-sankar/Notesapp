using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public DateTime? JoinedOn { get; set; }
      
        public  List<Magazine>? magazines { get; set; }
        
    }
}
