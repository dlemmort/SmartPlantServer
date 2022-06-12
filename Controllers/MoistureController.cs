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
    public class MoistureController : ControllerBase
    {
        private readonly PlantContext _context;

        public MoistureController(PlantContext context)
        {
            _context = context;
        }

        // GET: api/Moisture
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Moisture>>> GetMoistureLevels()
        {
          if (_context.MoistureLevels == null)
          {
              return NotFound();
          }
            return await _context.MoistureLevels.ToListAsync();
        }

        // GET: api/Moisture/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Moisture>>> GetMoisture(int id)
        {
          if (_context.MoistureLevels == null)
          {
              return NotFound();
          }

            return await _context.MoistureLevels.Where(x => x.PlantId == id).ToListAsync();
        }

       
    }
}
