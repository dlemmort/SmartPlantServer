namespace SmartPlantServer.Models;

public class Plant
{
    public int Id { get; set; }
    public int MqttId { get; set; }
    public string Name { get; set; } = String.Empty;
    public int CurrentMoisture { get; set; }
    public int CurrentWaterLevel { get; set; }

    public IEnumerable<Moisture> moistureLevels { get; set; } = new List<Moisture>();
    public IEnumerable<WaterLevel> waterLevels { get; set; } = new List<WaterLevel>();
}