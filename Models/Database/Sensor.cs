using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("sensor")]
public class Sensor
{
    [Column("id")] public int id { get; set; }
    [Column("plc_id")] public int plcId { get; set; }
    [Column("parameter_id")] public int controlParameterId { get; set; }
    [Column("model")] public string model { get; set; }

    public Plc plc { get; set; }
    public ControlParameter controlParameter { get; set; }
    public ICollection<SensorCheck> sensorChecks { get; set; }

    public Sensor(int plcId, int controlParameterId, string model)
    {
        this.plcId = plcId;
        this.controlParameterId = controlParameterId;
        this.model = model;
        sensorChecks = new List<SensorCheck>();
    }
}