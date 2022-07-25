using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class TelephoneNumber
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(20)"), MaxLength(20)] public string TelNumber { get; set; }

    public IEnumerable<TelephoneNumberType> TelephoneNumberType_Id { get; set; }
    public IEnumerable<City> City_Id { get; set; }
    public IEnumerable<Person> Person_Id { get; set; }

    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;
}
