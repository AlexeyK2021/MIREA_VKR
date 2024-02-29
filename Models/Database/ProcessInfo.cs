using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("process_info")]
public class ProcessInfo
{
    [Column("id")] public int id { get; set; }
    [Column("start")] public DateTime start { get; set; }
    [Column("end")] public DateTime end { get; set; }
    [Column("result_code_id")] public int resultId { get; set; }
    [Column("result_description")] public string resultDescription { get; set; }

    public ResultCode result { get; set; }
    public ICollection<Process> processes { get; set; }

    public ProcessInfo(DateTime start, DateTime end, string resultDescription, int resultId)
    {
        this.start = start;
        this.end = end;
        this.resultDescription = resultDescription;
        this.resultId = resultId;
    }
}