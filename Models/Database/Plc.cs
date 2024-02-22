using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("plc")]
public class Plc
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    [Column("ip")] public string ip { get; set; }
    [Column("port")] public string port { get; set; }
    [Column("location")] public string location { get; set; }

    public Plc(string ip, string port, string location, string name)
    {
        this.ip = ip;
        this.port = port;
        this.location = location;
        this.name = name;
    }

    public override string ToString()
    {
        return $"PLC ({name}): ip={ip}:{port}; location={location}";
    }
}