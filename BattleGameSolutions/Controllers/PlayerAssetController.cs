using BattleGameAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BattleGameAPI.Controllers
{
    [ApiController]
    [Route("api/playerassets")]
    public class PlayerAssetController : ControllerBase
    {
        private readonly BattleGameDbContext _context;

        public PlayerAssetController(BattleGameDbContext context)
        {
            _context = context;
        }

        [HttpGet("get/{playerId}")]
        public IActionResult GetAssetsByPlayer(Guid playerId)
        {
            var assets = from pa in _context.PlayerAssets
                join p in _context.Players on pa.PlayerId equals p.PlayerId
                join a in _context.Assets on pa.AssetId equals a.AssetId
                where p.PlayerId == playerId
                select new
                {
                    p.PlayerName,
                    p.Level,
                    p.Age,
                    AssetName = a.AssetName
                };

            return Ok(assets.ToList());
        }
    }
}