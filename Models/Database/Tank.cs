using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("tank")]
public class Tank
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    [Column("description")] public string description { get; set; }
    
    public ICollection<Plc> plcs { get; set; }
    public ICollection<Process> processes { get; set; }

    public Tank(string name)
    {
        this.name = name;
        plcs = new List<Plc>();
        processes = new List<Process>();
    }
}