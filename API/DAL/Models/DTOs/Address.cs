using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;
public partial class Address
{
    [Key] public int Id { get; set; }
    [Required, DataType("varchar(200)"), MaxLength(200)] public string AddressBlob { get; set; }
    [Required, DataType("bit")] public bool IsDeleted { get; set; } = false;

    public IEnumerable<AddressType> AddressType_Id { get; set; }
    public IEnumerable<City> City_Id { get; set; }
    public IEnumerable<Person> Person_Id { get; set; }
}
