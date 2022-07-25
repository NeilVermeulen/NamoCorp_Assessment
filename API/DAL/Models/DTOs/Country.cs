using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class Country
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(50)"), MaxLength(50)] public string CountryName { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string InternationalPostalCode { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string InternationalDialingCode { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
    public State State { get; set; }
}
