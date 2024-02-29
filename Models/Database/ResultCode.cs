using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("result_code")]
public class ResultCode
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }

    public ICollection<ProcessInfo> processInfos { get; set; }

    public ResultCode(string name)
    {
        this.name = name;
    }
}