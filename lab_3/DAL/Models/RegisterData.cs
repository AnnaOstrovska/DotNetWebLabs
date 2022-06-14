using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class RegisterData : IEntity
    {       
        [Key]
        public int Id { get; set; }
        
        [Required]
        public List<Doctor> Doctor { get; set; }
    }
}
