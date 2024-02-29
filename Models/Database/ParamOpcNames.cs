using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("param_opc_names")]
public class ParamOpcNames
{
    [Column("id")] public int id { get; set; }
    [Column("min_value_topic")] public string minValueName { get; set; }
    [Column("max_value_topic")] public string maxValueName { get; set; }
    [Column("current_value_topic")] public string currentValueName { get; set; }

    public ICollection<ControlParameter> controlParameter { get; set; }

    public ParamOpcNames(string minValueName, string maxValueName, string currentValueName)
    {
        this.minValueName = minValueName;
        this.maxValueName = maxValueName;
        this.currentValueName = currentValueName;
    }
}