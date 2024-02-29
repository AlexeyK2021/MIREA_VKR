using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("parameter_log")]
public class ParameterLog
{
    [Column("id")] public int id { get; set; }
    [Column("datetime")] public DateTime datetime { get; set; }
    [Column("parameter_id")] public int parameterId { get; set; }
    [Column("process_id")] public int processId { get; set; }

    public Process process { get; set; }
    public ControlParameter controlParameter { get; set; }

    public ParameterLog(DateTime datetime, int parameterId, int processId)
    {
        this.datetime = datetime;
        this.parameterId = parameterId;
        this.processId = processId;
    }
}