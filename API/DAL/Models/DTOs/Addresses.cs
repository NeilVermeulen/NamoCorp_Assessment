using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;
public partial class Addresses
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(200)] public string Address { get; set; }

    [Required, ForeignKey("AddressTypes")] public int AddressTypes_Id { get; set; }
    [Required, ForeignKey("Cities")] public int Cities_Id { get; set; }
    [Required, ForeignKey("People")] public int People_Ip { get; set; }
}
