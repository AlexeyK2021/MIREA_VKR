using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("control_parameter")]
public class ControlParameter
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    [Column("min_value")] public float minValue { get; set; }
    [Column("max_value")] public float maxValue { get; set; }
    [Column("opc_name_id")] public int opcNameId { get; set; }
    [Column("type_id")] public int typeId { get; set; }

    public ParamOpcNames opcName { get; set; }
    public ICollection<Sensor> sensor { get; set; }
    public ICollection<ParameterLog> logs { get; set; }
    public ParameterType type { get; set; }

    public ControlParameter(string name, float minValue, float maxValue, int opcNameId, int typeId)
    {
        this.name = name;
        this.minValue = minValue;
        this.maxValue = maxValue;
        this.opcNameId = opcNameId;
        this.typeId = typeId;

        sensor = new List<Sensor>();
        logs = new List<ParameterLog>();
    }

    public ControlParameter(string name, float minValue, float maxValue, int typeId)
    {
        this.name = name;
        this.minValue = minValue;
        this.maxValue = maxValue;
        this.typeId = typeId;
    }

    public ControlParameter()
    {
    }
}