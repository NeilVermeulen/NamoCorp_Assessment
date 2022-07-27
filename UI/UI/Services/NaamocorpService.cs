using UI.Models;

namespace UI.Services
{
    public class NaamocorpService : INaamocorpService
    {
        private readonly HttpClient _httpClient;

        public NaamocorpService(HttpClient httpClient)
        {
            _httpClient = httpClient;   
        }

        public Task<Address> CreateAddress(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<AddressType> CreateAddressType(AddressType entity)
        {
            throw new NotImplementedException();
        }

        public Task<City> CreateCity(City entity)
        {
            throw new NotImplementedException();
        }

        public Task<Country> CreateCountry(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<Person> CreatePerson(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<State> CreateState(State entity)
        {
            throw new NotImplementedException();
        }

        public Task<TelephoneNumber> CreateTelephoneNumber(TelephoneNumber entity)
        {
            throw new NotImplementedException();
        }

        public Task<TelephoneNumberType> CreateTelephoneNumberType(TelephoneNumberType entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAddressType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteState(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTelephoneNumber(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTelephoneNumberType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Person(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> Person()
        {
            throw new NotImplementedException();
        }

        public Task<Address> ReadAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> ReadAddress()
        {
            throw new NotImplementedException();
        }

        public Task<AddressType> ReadAddressType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AddressType>> ReadAddressType()
        {
            throw new NotImplementedException();
        }

        public Task<City> ReadCity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<City>> ReadCity()
        {
            throw new NotImplementedException();
        }

        public Task<Country> ReadCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Country>> ReadCountry()
        {
            throw new NotImplementedException();
        }

        public Task<State> ReadState(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<State>> ReadState()
        {
            throw new NotImplementedException();
        }

        public Task<TelephoneNumber> ReadTelephoneNumber(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TelephoneNumber>> ReadTelephoneNumber()
        {
            throw new NotImplementedException();
        }

        public Task<TelephoneNumberType> ReadTelephoneNumberType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TelephoneNumberType>> ReadTelephoneNumberType()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAddress(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAddressType(AddressType entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCity(City entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCountry(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePerson(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateState(State entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTelephoneNumber(TelephoneNumber entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTelephoneNumberType(TelephoneNumberType entity)
        {
            throw new NotImplementedException();
        }
    }
}
