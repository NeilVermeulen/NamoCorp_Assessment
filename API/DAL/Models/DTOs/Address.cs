using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;
public partial class Address
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(200)"), MaxLength(200)] public string AddressBlob { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;

    [Required, ForeignKey("AddressTypes")] public int AddressTypes_Id { get; set; }
    [Required, ForeignKey("Cities")] public int Cities_Id { get; set; }
    [Required, ForeignKey("People")] public int People_Ip { get; set; }
}
