using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class State
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(50)"), MaxLength(50)] public string StateName { get; set; }

    [Required, ForeignKey("Country")] public int Country_Id { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
}
