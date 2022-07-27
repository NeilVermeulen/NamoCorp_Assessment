using System.ComponentModel.DataAnnotations;

namespace UI.Models;

public partial class TelephoneNumber
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string TelNumber { get; set; }

    public Int32 TelephoneNumberType_Id { get; set; }
    public Int32 City_Id { get; set; }
    public Int32 Person_Id { get; set; }

    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
}
