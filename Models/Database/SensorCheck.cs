using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("sensor_check")]
public class SensorCheck
{
    [Column("id")] public int id { get; set; }
    [Column("date")] public DateOnly date { get; set; }
    [Column("description")] public string description { get; set; }
    [Column("sensor_id")] public int sensorId { get; set; }

    public Sensor sensor { get; set; }

    public SensorCheck(DateOnly date, string description)
    {
        this.date = date;
        this.description = description;
    }
}