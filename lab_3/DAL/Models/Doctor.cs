using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Doctor : IEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required] 
        public string Name { get; set; }
        
        [Required]
        public Dictionary<DateTime, bool> DatesForEntries { get; set; }
    }
}
