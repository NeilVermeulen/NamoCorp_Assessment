using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class Countries
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(50)] public string Country { get; set; }
    [Required, MaxLength(20)] public string InternationalPostalCode { get; set; }
    [Required, MaxLength(20)] public string InternationalDialingCode { get; set; }
}
