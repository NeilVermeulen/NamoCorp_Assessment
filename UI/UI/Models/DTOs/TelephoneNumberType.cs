using System.ComponentModel.DataAnnotations;

namespace UI.Models;
public partial class TelephoneNumberType
{
    [Key]public int Id { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string NumberType { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
    public TelephoneNumber TelephoneNumber { get; set; }
}
