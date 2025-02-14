using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BattleGameAPI.Models
{
    public class PlayerAsset
    {
        public Guid PlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }

        public Guid AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset Asset { get; set; }
    }
}