using System;

namespace AllenEcommerceBlazorApp.Client.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _htpp;

        public AddressService(HttpClient htpp)
        {
           _htpp = htpp;
        }

        public async Task<Address> AddorUpdateAdress(Address address)
        {
            var response = await _htpp.PostAsJsonAsync("api/address", address);
            return response.Content.ReadFromJsonAsync
                <ServiceResponse<Address>>().Result.Data;
        }

        public async Task<Address> GetAdress()
        {
            var response = await _htpp.GetFromJsonAsync<ServiceResponse<Address>>("api/address");

            return response.Data;
        }
    }   
}

