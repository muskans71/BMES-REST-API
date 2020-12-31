using BMES_REST_API.Database;
using BMES_REST_API.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        private BmesDbContext _context;

        public AddressRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Address FindAddressById(long id)
        {
            var address = _context.Address.Find(id);
            return address;
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            var addresses = _context.Address;
            return addresses;
        }

        public void SaveAddress(Address address)
        {
            _context.Address.Add(address);
            _context.SaveChanges();
        }

        public void UpdateAddress(Address address)
        {
            _context.Address.Update(address);
            _context.SaveChanges();
        }

        public void DeleteAddress(Address address)
        {
            _context.Address.Remove(address);
            _context.SaveChanges();
        }
    }
}
