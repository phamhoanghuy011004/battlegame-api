using BattleGameAPI.Data;
using BattleGameAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BattleGameAPI.Controllers
{
    [ApiController]
    [Route("api/asset")]
    public class AssetController : ControllerBase
    {
        private readonly BattleGameDbContext _context;

        public AssetController(BattleGameDbContext context)
        {
            _context = context;
        }

        [HttpPost("create")]
        public IActionResult CreateAsset([FromBody] Asset asset)
        {
            _context.Assets.Add(asset);
            _context.SaveChanges();
            return Ok(asset);
        }
    }
}