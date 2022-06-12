namespace SmartPlantServer.Models;

public class WaterLevel
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public int Percentage { get; set; }
    public int PlantId { get; set; }
}