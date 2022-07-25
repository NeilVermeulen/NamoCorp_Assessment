using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class TelephoneNumber
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string TelNumber { get; set; }

    [Required, ForeignKey("TelephoneNumberType")] public int TelephoneNumberType_Id { get; set; }
    [Required, ForeignKey("Cities")] public int Cities_Id { get; set; }
    [Required, ForeignKey("People")] public int People_Id { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
}
