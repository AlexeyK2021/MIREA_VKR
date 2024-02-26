using System.ComponentModel.DataAnnotations.Schema;

namespace opcUaWebMVC.Models.Database;

[Table("location")]
public class Location
{
    [Column("id")] public int id { get; set; }
    [Column("name")] public string name { get; set; }
    
    public ICollection<Plc> Plcs { get; set; }

    public Location(string name)
    {
        this.name = name;
    }

    public Location()
    {
    }

    public override string ToString()
    {
        return $"Location (id={id}; name={name})";
    }
}