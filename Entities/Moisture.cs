namespace SmartPlantServer.Models;

public class Moisture
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public int Percentage { get; set; }
    public int PlantId { get; set; }
}