using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Models;
public partial class Address
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(200)"), MaxLength(200)] public string AddressBlob { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
    public Int32 AddressType_Id { get; set; }
    public Int32 City_Id { get; set; }
    public Int32 Person_Id { get; set; }
}
