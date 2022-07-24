using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;
public partial class TelephoneNumberTypes
{
    [Key]public int Id { get; set; }
    [Required,MaxLength(20)]public string TelephoneNumberType { get; set; }
}
