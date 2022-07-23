using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class HikesController : BaseApiController
    {
        private readonly DataContext _context;

        public HikesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]   // Getting ALL of the hikes (/hikes)
        public async Task<ActionResult<List<Hike>>> GetHikes()
        {
            return await _context.Hikes.ToListAsync();
        }

        [HttpGet("{id}")]   // Getting one specific hike by id (/hikes/id)
        public async Task<ActionResult<Hike>> GetHike(Guid id)
        {
            return await _context.Hikes.FindAsync(id);

            // TODO: Error handling if someone looks for an id that doesn't exist
        }
    }
}
