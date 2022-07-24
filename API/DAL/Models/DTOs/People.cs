using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class People
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(20)] public string FullName { get; set; }
    [MaxLength(20)] public string? Surname { get; set; }
    public DateTime? DoB { get; set; }
}
