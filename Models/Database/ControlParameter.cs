using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("control_parameter")]
public class ControlParameter
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    [Column("min_value")] public float minValue { get; set; }
    [Column("max_value")] public float maxValue { get; set; }
    [Column("opc_name_min")] public string opcNameMin { get; set; }
    [Column("opc_name_max")] public string opcNameMax { get; set; }

    public ControlParameter(string name, float minValue, float maxValue, string opcNameMin, string opcNameMax)
    {
        this.name = name;
        this.minValue = minValue;
        this.maxValue = maxValue;
        this.opcNameMin = opcNameMin;
        this.opcNameMax = opcNameMax;
    }
}