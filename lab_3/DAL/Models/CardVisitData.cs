using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class CardVisitData : IEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required] 
        public DateTime DateOfVisiting { get; set; }
        
        [Required] 
        public string Diagnosis { get; set; }
        
        [Required]
        public Doctor Doctor { get; set; }
    }
}
