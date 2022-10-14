using System;
namespace AllenEcommerceBlazorApp.Server.Services.AddressService
{
    public interface IAddressService
    {
        Task<ServiceResponse<Address>> GetAddress();

        Task<ServiceResponse<Address>> AddorUpdateAddress(Address address);
    }
}

