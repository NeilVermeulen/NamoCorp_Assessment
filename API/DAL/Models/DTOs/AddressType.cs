using System.ComponentModel.DataAnnotations;

namespace DAL.Models;
public partial class AddressType
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string TypeOfAddress { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
    public Address Address { get; set; }
}
