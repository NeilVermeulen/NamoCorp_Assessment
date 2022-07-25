using DAL.Models;
using DAL.DataAccess;

namespace API.DataCache;

public class AddressCache : IAddressCache
{
    DataContext _db;
    private List<Address> _addresses = new List<Address>();
    public List<Address> Addresses 
    {
        get => ReadAll();
    }

    private List<Address> ReadAll()
    {
        if (!_addresses.Any())
        {
            var addresses = (from tb in _db.Addresses where tb.IsDeleted == false select tb).ToList();
            _addresses = addresses;
            return _addresses;
        }
        else return null;

    }

    public List<Address> All()
    {
        throw new NotImplementedException();
    }

    public int Create(Address Address)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Address Address)
    {
        throw new NotImplementedException();
    }

    public Address Get(int Id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Address Address)
    {
        throw new NotImplementedException();
    }
}
