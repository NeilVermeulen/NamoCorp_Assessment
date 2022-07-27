using UI.Models;

namespace UI.Services
{
    public interface INaamocorpService
    {
        #region Web methods

        #region Address
        Task<Address> CreateAddress(Address entity);
        Task<Address> ReadAddress(int id);
        Task<IEnumerable<Address>> ReadAddress();
        Task<bool> UpdateAddress(Address entity);
        Task<bool> DeleteAddress(int id);
        #endregion

        #region AddressType
        Task<AddressType> CreateAddressType(AddressType entity);
        Task<AddressType> ReadAddressType(int id);
        Task<IEnumerable<AddressType>> ReadAddressType();
        Task<bool> UpdateAddressType(AddressType entity);
        Task<bool> DeleteAddressType(int id);
        #endregion

        #region City
        Task<City> CreateCity(City entity);
        Task<City> ReadCity(int id);
        Task<IEnumerable<City>> ReadCity();
        Task<bool> UpdateCity(City entity);
        Task<bool> DeleteCity(int id);
        #endregion

        #region Country
        Task<Country> CreateCountry(Country entity);
        Task<Country> ReadCountry(int id);
        Task<IEnumerable<Country>> ReadCountry();
        Task<bool> UpdateCountry(Country entity);
        Task<bool> DeleteCountry(int id);
        #endregion

        #region Person
        Task<Person> CreatePerson(Person entity);
        Task<Person> Person(int id);
        Task<IEnumerable<Person>> Person();
        Task<bool> UpdatePerson(Person entity);
        Task<bool> DeletePerson(int id);
        #endregion

        #region State
        Task<State> CreateState(State entity);
        Task<State> ReadState(int id);
        Task<IEnumerable<State>> ReadState();
        Task<bool> UpdateState(State entity);
        Task<bool> DeleteState(int id);
        #endregion

        #region TelephoneNumber
        Task<TelephoneNumber> CreateTelephoneNumber(TelephoneNumber entity);
        Task<TelephoneNumber> ReadTelephoneNumber(int id);
        Task<IEnumerable<TelephoneNumber>> ReadTelephoneNumber();
        Task<bool> UpdateTelephoneNumber(TelephoneNumber entity);
        Task<bool> DeleteTelephoneNumber(int id);
        #endregion

        #region TelephoneNumberType
        Task<TelephoneNumberType> CreateTelephoneNumberType(TelephoneNumberType entity);
        Task<TelephoneNumberType> ReadTelephoneNumberType(int id);
        Task<IEnumerable<TelephoneNumberType>> ReadTelephoneNumberType();
        Task<bool> UpdateTelephoneNumberType(TelephoneNumberType entity);
        Task<bool> DeleteTelephoneNumberType(int id);
        #endregion

        #endregion
    }
}
