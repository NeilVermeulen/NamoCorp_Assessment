using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Models;

public partial class City
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(50)"), MaxLength(50)] public string CityName { get; set; }
    [Required, DataType("varchar(10)"), MaxLength(10)] public string TelephoneCode { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string PostalCode { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;

    public int State_Id { get; set; }

    public Address Address { get; set; }
    public TelephoneNumber TelephoneNumber { get; set; }

}
