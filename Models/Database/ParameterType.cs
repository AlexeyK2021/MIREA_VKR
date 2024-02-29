using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("parameter_type")]
public class ParameterType
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    
    public ICollection<ControlParameter> parametersList { get; set; }

    public ParameterType(string name)
    {
        this.name = name;
    }
}