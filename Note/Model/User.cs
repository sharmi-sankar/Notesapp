using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    public class User
    {
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public DateTime? JoinedOn { get; set; }

        public List <Noted> noteds { get; set; }
       
    }
}
