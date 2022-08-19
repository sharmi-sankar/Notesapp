using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
namespace Note.Model
{
    public class Magazine
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastupdatedOn { get; set; }

        public User User { get; set; }
        public int UserId
        {
            get; set;

        }

    }
   
}
