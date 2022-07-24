using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class States
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(50)] public string State { get; set; }

    [Required, ForeignKey("Countries")] public int Countries_Id { get; set; }
}
