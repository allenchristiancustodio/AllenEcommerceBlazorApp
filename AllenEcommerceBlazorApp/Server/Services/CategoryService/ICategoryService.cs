using System;
namespace AllenEcommerceBlazorApp.Server.Services.CategoryService
{
    public interface ICategoryService
    {

        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}

