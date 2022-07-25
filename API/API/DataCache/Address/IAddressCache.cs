namespace API.DataCache;

public interface IAddressCache
{
    List<DAL.Models.Address> Addresses { get; set; }
    int Create(DAL.Models.Address Address);
    List<DAL.Models.Address> All();
    DAL.Models.Address Get(int Id);
    bool Update(DAL.Models.Address Address);
    bool Delete(DAL.Models.Address Address);

}
