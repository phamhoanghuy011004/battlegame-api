using System.ComponentModel.DataAnnotations;

namespace BattleGameAPI.Models
{
    public class Asset
    {
        [Key]
        public Guid AssetId { get; set; } = Guid.NewGuid();
        
        [Required]
        public string AssetName { get; set; }
        
        public int LevelRequire { get; set; }
    }
}