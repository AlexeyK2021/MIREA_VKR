using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("process")]
public class Process
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    [Column("tank_id")] public int tankId { get; set; }
    [Column("process_info_id")] public int processInfoId { get; set; }

    public Tank tank { get; set; }
    public ProcessInfo processInfo { get; set; }
    public ICollection<ParameterLog> logs { get; set; }

    public Process(string name, int tankId, int processInfoId)
    {
        this.tankId = tankId;
        this.processInfoId = processInfoId;
        this.name = name;
        logs = new List<ParameterLog>();
    }
}