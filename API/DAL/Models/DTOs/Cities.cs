using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class Cities
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(50)] public string City { get; set; }
    [Required, MaxLength(10)] public string TelephoneCode { get; set; }
    [Required, MaxLength(20)] public string PostalCode { get; set; }

    [Required, ForeignKey("States")] public int States_Id { get; set; }
    
}
