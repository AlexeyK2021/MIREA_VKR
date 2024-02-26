using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("plc")]
public class Plc
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    [Column("ip")] public string ip { get; set; }
    [Column("port")] public string port { get; set; }
    [Column("location_id")] public int locationId { get; set; }
    public Location location { get; set; } = null!;

    public Plc(string ip, string port, int locationId, string name)
    {
        this.ip = ip;
        this.port = port;
        this.locationId = locationId;
        this.name = name;
    }

    public override string ToString()
    {
        return $"PLC ({name}): ip={ip}:{port}; location={location}";
    }
}