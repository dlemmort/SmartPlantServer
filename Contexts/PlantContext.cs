using Microsoft.EntityFrameworkCore;
using SmartPlantServer.Models;

namespace SmartPlantServer.Contexts;

public class PlantContext : DbContext
{
    public DbSet<Plant> Plants { get; set; }
    public DbSet<Moisture> MoistureLevels { get; set; }
    public DbSet<WaterLevel> WaterLevels { get; set; }

    public PlantContext(DbContextOptions<PlantContext> options) : base(options) { }

    
    
}