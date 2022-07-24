using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class TelephoneNumbers
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(20)] public string TelephoneNumber { get; set; }

    [Required, ForeignKey("TelephoneNumberTypes")] public int TelephoneNumberTypes_Id { get; set; }
    [Required, ForeignKey("Cities")] public int Cities_Id { get; set; }
    [Required, ForeignKey("People")] public int People_Id { get; set; }
}
