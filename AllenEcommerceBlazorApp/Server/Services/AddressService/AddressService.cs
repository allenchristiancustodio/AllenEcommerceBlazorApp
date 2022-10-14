using System;

namespace AllenEcommerceBlazorApp.Server.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly DataContext _context;
        private readonly IAuthService _authService;

        public AddressService(DataContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public async Task<ServiceResponse<Address>> AddorUpdateAddress(Address address)
        {
            var response =  new ServiceResponse<Address>();
            var dbAdress = (await GetAddress()).Data;

            if(dbAdress == null)
            {
                address.UserId = _authService.GetUserId();
                _context.Addresses.Add(address);
                response.Data = address;

                
            }

            else
            {

                dbAdress.FirstName = address.FirstName;
                dbAdress.LastName = address.LastName;
                dbAdress.Street = address.Street;
                dbAdress.City = address.City;
                dbAdress.State = address.State;
                dbAdress.Zip = address.Zip;
                dbAdress.Country = address.Country;

                response.Data = dbAdress;
              
            }
            await _context.SaveChangesAsync();

            return response;
        }

        public async Task<ServiceResponse<Address>> GetAddress()
        {
            var userId = _authService.GetUserId();
            var address = await _context.Addresses.FirstOrDefaultAsync(a => a.UserId == userId);

            return new ServiceResponse<Address> { Data = address };
        }
    }
}

