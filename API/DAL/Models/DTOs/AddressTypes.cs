using System.ComponentModel.DataAnnotations;

namespace DAL.Models;
public partial class AddressTypes
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(20)] public string AddressType { get; set; }
}
