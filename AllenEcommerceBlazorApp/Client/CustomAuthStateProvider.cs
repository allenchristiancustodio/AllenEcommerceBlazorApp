using System;
using Microsoft.AspNetCore.Components.Authorization;

namespace AllenEcommerceBlazorApp.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            throw new NotImplementedException();
        }
    }
}

