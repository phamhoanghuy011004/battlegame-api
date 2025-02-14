using BattleGameAPI.Data;
using BattleGameAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BattleGameAPI.Controllers
{
    [ApiController]
    [Route("api/player")]
    public class PlayerController : ControllerBase
    {
        private readonly BattleGameDbContext _context;

        public PlayerController(BattleGameDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult RegisterPlayer([FromBody] Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return Ok(player);
        }
    }
}