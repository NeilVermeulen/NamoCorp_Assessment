using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataAccess;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) {  }
    public DbSet<AddressType> AddressTypes { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<TelephoneNumber> TelephoneNumbers { get; set; }
    public DbSet<TelephoneNumberType> TelephoneNumberTypes { get; set; }
}
