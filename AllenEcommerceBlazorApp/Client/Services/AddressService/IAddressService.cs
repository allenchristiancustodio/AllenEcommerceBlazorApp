using System;
namespace AllenEcommerceBlazorApp.Client.Services.AddressService
{
    public interface IAddressService
    {
        Task<Address> GetAdress();

        Task<Address> AddorUpdateAdress(Address address);
    }
}

