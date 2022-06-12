using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartPlantServer.Contexts;
using SmartPlantServer.Models;

namespace SmartPlantServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterLevelController : ControllerBase
    {
        private readonly PlantContext _context;

        public WaterLevelController(PlantContext context)
        {
            _context = context;
        }

        // GET: api/WaterLevel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<WaterLevel>>> GetWaterLevel(int id)
        {
          if (_context.WaterLevels == null)
          {
              return NotFound();
          }

          return await _context.WaterLevels.Where(x => x.PlantId == id).ToListAsync();
        }
    }
}
