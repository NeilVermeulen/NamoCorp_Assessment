using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class Person
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string FullName { get; set; }
    [DataType("varchar(20)"), MaxLength(20)] public string? Surname { get; set; }
    public DateTime? DoB { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
    public Address Address { get; set; }
    public TelephoneNumber TelephoneNumber { get; set; }
}
