global using System.Net.Http.Json;
global using AllenEcommerceBlazorApp.Shared;
global using AllenEcommerceBlazorApp.Client.Services.ProductServices;
global using AllenEcommerceBlazorApp.Client.Services.CategoryService;
global using AllenEcommerceBlazorApp.Client.Services.CartService;
global using AllenEcommerceBlazorApp.Client.Services.AuthService;
global using AllenEcommerceBlazorApp.Client.Services.OrderService;
global using Microsoft.AspNetCore.Components.Authorization;
global using AllenEcommerceBlazorApp.Client.Services.AddressService;
global using AllenEcommerceBlazorApp.Client.Services.ProductTypeService;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AllenEcommerceBlazorApp.Client;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();

