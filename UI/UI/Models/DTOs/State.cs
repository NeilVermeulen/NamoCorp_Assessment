using System.ComponentModel.DataAnnotations;

namespace UI.Models;

public partial class State
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(50)"), MaxLength(50)] public string StateName { get; set; }

    public IEnumerable<Country> Country_Id { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
    public City City { get; set; }
}
