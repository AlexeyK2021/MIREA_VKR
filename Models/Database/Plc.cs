using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("plc")]
public class Plc
{
    [Column("id")] public int id { get; set; }
    [Column("model")] public string model { get; set; }
    [Column("ip")] public string ip { get; set; }
    [Column("port")] public string port { get; set; }
    [Column("tank_id")] public int tankId { get; set; }

    public Tank tank { get; set; }
    public ICollection<Sensor> sensors { get; set; }

    public Plc(string model, string ip, string port, int tankId)
    {
        this.model = model;
        this.ip = ip;
        this.port = port;
        this.tankId = tankId;
        sensors = new List<Sensor>();
    }

    public override string ToString()
    {
        return $"PLC ({model}): ip={ip}:{port}; tankId={tankId}";
    }
}