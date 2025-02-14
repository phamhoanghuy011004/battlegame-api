using System.ComponentModel.DataAnnotations;

namespace BattleGameAPI.Models
{
    public class Player
    {
        [Key]
        public Guid PlayerId { get; set; } = Guid.NewGuid();
        
        [Required]
        public string PlayerName { get; set; }
        
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public string Email { get; set; }
    }
}